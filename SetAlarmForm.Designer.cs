
namespace CAL_FinalProject
{
    partial class SetAlarmForm
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
            this.dtpAlarm = new System.Windows.Forms.DateTimePicker();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpAlarm
            // 
            this.dtpAlarm.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpAlarm.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dtpAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlarm.Location = new System.Drawing.Point(138, 64);
            this.dtpAlarm.Name = "dtpAlarm";
            this.dtpAlarm.ShowUpDown = true;
            this.dtpAlarm.Size = new System.Drawing.Size(244, 28);
            this.dtpAlarm.TabIndex = 0;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnSet.Location = new System.Drawing.Point(76, 137);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(116, 46);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnCancel.Location = new System.Drawing.Point(325, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 46);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SetAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAL_FinalProject.Properties.Resources.crystal;
            this.ClientSize = new System.Drawing.Size(507, 243);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.dtpAlarm);
            this.Name = "SetAlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetAlarmForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpAlarm;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnCancel;
    }
}