
namespace CAL_FinalProject
{
    partial class AlarmClockApp
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
            this.lstAlarms = new System.Windows.Forms.ListBox();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.btnDeleteAlarm = new System.Windows.Forms.Button();
            this.btnSnooze = new System.Windows.Forms.Button();
            this.btnOffAlarm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClockLabel = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAlarms
            // 
            this.lstAlarms.FormattingEnabled = true;
            this.lstAlarms.ItemHeight = 16;
            this.lstAlarms.Location = new System.Drawing.Point(32, 42);
            this.lstAlarms.Name = "lstAlarms";
            this.lstAlarms.Size = new System.Drawing.Size(262, 292);
            this.lstAlarms.TabIndex = 0;
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetAlarm.Location = new System.Drawing.Point(46, 40);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(116, 46);
            this.btnSetAlarm.TabIndex = 2;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // btnDeleteAlarm
            // 
            this.btnDeleteAlarm.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnDeleteAlarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteAlarm.Location = new System.Drawing.Point(205, 40);
            this.btnDeleteAlarm.Name = "btnDeleteAlarm";
            this.btnDeleteAlarm.Size = new System.Drawing.Size(116, 46);
            this.btnDeleteAlarm.TabIndex = 3;
            this.btnDeleteAlarm.Text = "Delete";
            this.btnDeleteAlarm.UseVisualStyleBackColor = true;
            this.btnDeleteAlarm.Click += new System.EventHandler(this.btnDeleteAlarm_Click);
            // 
            // btnSnooze
            // 
            this.btnSnooze.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnSnooze.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSnooze.Location = new System.Drawing.Point(46, 107);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(116, 46);
            this.btnSnooze.TabIndex = 5;
            this.btnSnooze.Text = "Snooze";
            this.btnSnooze.UseVisualStyleBackColor = true;
            this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);
            // 
            // btnOffAlarm
            // 
            this.btnOffAlarm.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnOffAlarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOffAlarm.Location = new System.Drawing.Point(205, 107);
            this.btnOffAlarm.Name = "btnOffAlarm";
            this.btnOffAlarm.Size = new System.Drawing.Size(116, 46);
            this.btnOffAlarm.TabIndex = 6;
            this.btnOffAlarm.Text = "Turn Off";
            this.btnOffAlarm.UseVisualStyleBackColor = true;
            this.btnOffAlarm.Click += new System.EventHandler(this.btnOffAlarm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnSetAlarm);
            this.groupBox3.Controls.Add(this.btnDeleteAlarm);
            this.groupBox3.Controls.Add(this.btnSnooze);
            this.groupBox3.Controls.Add(this.btnOffAlarm);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(20, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 182);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alarm Controls";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSetTime);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(399, -20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 479);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetTime.Location = new System.Drawing.Point(20, 412);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(362, 31);
            this.btnSetTime.TabIndex = 7;
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblClockLabel);
            this.groupBox2.Controls.Add(this.lblClock);
            this.groupBox2.Controls.Add(this.lblTemperature);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(20, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 172);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time and Temperature";
            // 
            // lblClockLabel
            // 
            this.lblClockLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblClockLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblClockLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClockLabel.Location = new System.Drawing.Point(30, 30);
            this.lblClockLabel.Name = "lblClockLabel";
            this.lblClockLabel.Size = new System.Drawing.Size(313, 39);
            this.lblClockLabel.TabIndex = 7;
            this.lblClockLabel.Text = "Real-Time Clock";
            this.lblClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblClock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClock.Location = new System.Drawing.Point(16, 69);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(327, 44);
            this.lblClock.TabIndex = 1;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperature
            // 
            this.lblTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblTemperature.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTemperature.Location = new System.Drawing.Point(23, 112);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(320, 39);
            this.lblTemperature.TabIndex = 4;
            this.lblTemperature.Text = "0";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lstAlarms);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(36, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarm List";
            // 
            // AlarmClockApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAL_FinalProject.Properties.Resources.crystal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlarmClockApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Clock App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlarmClockApp_FormClosing);
            this.Load += new System.EventHandler(this.AlarmClockApp_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstAlarms;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.Button btnDeleteAlarm;
        private System.Windows.Forms.Button btnSnooze;
        private System.Windows.Forms.Button btnOffAlarm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblClockLabel;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetTime;
    }
}

