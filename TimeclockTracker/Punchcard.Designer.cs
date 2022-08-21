namespace TimeclockTracker
{
    partial class TimeclockTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeclockTracker));
            this.label1 = new System.Windows.Forms.Label();
            this.facultyId = new System.Windows.Forms.TextBox();
            this.clockIn = new System.Windows.Forms.Button();
            this.clockOut = new System.Windows.Forms.Button();
            this.printLog = new System.Windows.Forms.ListBox();
            this.lunchStart = new System.Windows.Forms.Button();
            this.lunchEnd = new System.Windows.Forms.Button();
            this.facultyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // facultyId
            // 
            this.facultyId.Location = new System.Drawing.Point(12, 25);
            this.facultyId.Name = "facultyId";
            this.facultyId.Size = new System.Drawing.Size(100, 20);
            this.facultyId.TabIndex = 2;
            this.facultyId.TextChanged += new System.EventHandler(this.facultyId_TextChanged);
            // 
            // clockIn
            // 
            this.clockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.clockIn.ForeColor = System.Drawing.Color.White;
            this.clockIn.Location = new System.Drawing.Point(121, 63);
            this.clockIn.Name = "clockIn";
            this.clockIn.Size = new System.Drawing.Size(88, 37);
            this.clockIn.TabIndex = 4;
            this.clockIn.Text = "CLOCK IN";
            this.clockIn.UseVisualStyleBackColor = false;
            this.clockIn.Click += new System.EventHandler(this.clockIn_Click);
            // 
            // clockOut
            // 
            this.clockOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(14)))), ((int)(((byte)(42)))));
            this.clockOut.ForeColor = System.Drawing.Color.White;
            this.clockOut.Location = new System.Drawing.Point(121, 164);
            this.clockOut.Name = "clockOut";
            this.clockOut.Size = new System.Drawing.Size(88, 37);
            this.clockOut.TabIndex = 5;
            this.clockOut.Text = "CLOCK OUT";
            this.clockOut.UseVisualStyleBackColor = false;
            this.clockOut.Click += new System.EventHandler(this.clockOut_Click);
            // 
            // printLog
            // 
            this.printLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printLog.FormattingEnabled = true;
            this.printLog.Location = new System.Drawing.Point(12, 218);
            this.printLog.Name = "printLog";
            this.printLog.Size = new System.Drawing.Size(327, 121);
            this.printLog.TabIndex = 8;
            // 
            // lunchStart
            // 
            this.lunchStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.lunchStart.ForeColor = System.Drawing.Color.White;
            this.lunchStart.Location = new System.Drawing.Point(150, 106);
            this.lunchStart.Name = "lunchStart";
            this.lunchStart.Size = new System.Drawing.Size(118, 23);
            this.lunchStart.TabIndex = 9;
            this.lunchStart.Text = "OUT TO LUNCH";
            this.lunchStart.UseVisualStyleBackColor = false;
            this.lunchStart.Click += new System.EventHandler(this.lunchStart_Click);
            // 
            // lunchEnd
            // 
            this.lunchEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.lunchEnd.ForeColor = System.Drawing.Color.White;
            this.lunchEnd.Location = new System.Drawing.Point(150, 135);
            this.lunchEnd.Name = "lunchEnd";
            this.lunchEnd.Size = new System.Drawing.Size(118, 23);
            this.lunchEnd.TabIndex = 10;
            this.lunchEnd.Text = "BACK FROM LUNCH";
            this.lunchEnd.UseVisualStyleBackColor = false;
            this.lunchEnd.Click += new System.EventHandler(this.lunchEnd_Click);
            // 
            // facultyName
            // 
            this.facultyName.AutoSize = true;
            this.facultyName.Location = new System.Drawing.Point(118, 28);
            this.facultyName.Name = "facultyName";
            this.facultyName.Size = new System.Drawing.Size(57, 13);
            this.facultyName.TabIndex = 11;
            this.facultyName.Text = "Not Found";
            // 
            // TimeclockTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(352, 344);
            this.Controls.Add(this.facultyName);
            this.Controls.Add(this.lunchEnd);
            this.Controls.Add(this.lunchStart);
            this.Controls.Add(this.printLog);
            this.Controls.Add(this.clockOut);
            this.Controls.Add(this.clockIn);
            this.Controls.Add(this.facultyId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeclockTracker";
            this.Text = "Timeclock Tracker";
            this.Load += new System.EventHandler(this.Punchcard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox facultyId;
        private System.Windows.Forms.Button clockIn;
        private System.Windows.Forms.Button clockOut;
        private System.Windows.Forms.ListBox printLog;
        private System.Windows.Forms.Button lunchStart;
        private System.Windows.Forms.Button lunchEnd;
        private System.Windows.Forms.Label facultyName;
    }
}

