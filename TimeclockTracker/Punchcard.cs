using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;

namespace TimeclockTracker
{
    public partial class Punchcard : Form
    {
        // Define request parameters.
        String spreadsheetId = ConfigurationManager.AppSettings["sheet"];
        String logSheet = ConfigurationManager.AppSettings["log"];
        String facultySheet = ConfigurationManager.AppSettings["faculty"];
        SheetsService service;
        Dictionary<string, Faculty> facultyData = new Dictionary<string, Faculty>();
        public Punchcard()
        {
            InitializeComponent();
        }

        private void Punchcard_Load(object sender, EventArgs e)
        {
            UserCredential credential;

            // The file token.json stores the user's access and refresh tokens, and is created
            // automatically when the authorization flow completes for the first time.
            string credPath = "token.json";
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.FromFile("credentials.json").Secrets,
                new string[] { "https://www.googleapis.com/auth/spreadsheets" },
                "user",
                CancellationToken.None,
                new FileDataStore(credPath, true)).Result;
            Console.WriteLine("Credential file saved to: " + credPath);
            // Create Google Sheets API service.
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Punchcard",
            });

            var req = service.Spreadsheets.Values.Get(spreadsheetId, facultySheet + "!A:C");
            var facultyResponse = req.Execute();
            facultyResponse.Values.RemoveAt(0); // remove header row

            foreach (List<Object> faculty in facultyResponse.Values)
            {
                facultyData.Add(faculty[0].ToString(), new Faculty(faculty[0].ToString(), faculty[1].ToString(), faculty[2].ToString()));
            }
        }

        private void facultyId_TextChanged(object sender, EventArgs e)
        {
            Faculty faculty;
            facultyData.TryGetValue(facultyId.Text.Trim(), out faculty);
            facultyName.Text = faculty == null ? "Not Found": faculty.name;
        }

        private void logRows(String type)
        {
            try
            {
                var faculty = facultyData[facultyId.Text.Trim()];
                var time = DateTime.Now;

                var range = new ValueRange()
                {
                    Values = new List<IList<object>> {
                            new List<object> {
                                time.ToString(), type, faculty.id, faculty.name
                            }
                        }
                };

                var append = service.Spreadsheets.Values.Append(range, spreadsheetId, logSheet + "!A1:A");
                append.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
                append.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
                var resp = append.Execute();
                printLog.Items.Add($"{type} {faculty.name} {time}");

                facultyId.Text = "";
            } catch (Exception e) {
                printLog.Items.Add($"ERROR: {e.Message}");
            }
        }

        private void clockIn_Click(object sender, EventArgs e)
        {
            logRows("CLOCK_IN");
        }

        private void clockOut_Click(object sender, EventArgs e)
        {
            logRows("CLOCK_OUT");
        }

        private void lunchStart_Click(object sender, EventArgs e)
        {
            logRows("LUNCH_START");
        }

        private void lunchEnd_Click(object sender, EventArgs e)
        {
            logRows("LUNCH_END");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    internal class Faculty
    {
        public Faculty(string id, string last, string first) {
            this.id = id;
            this.last = last;
            this.first = first;
        }
        public string id;
        public string last;
        public string first;

        public string name { get { return last + ", " + first; } }
    }
}
