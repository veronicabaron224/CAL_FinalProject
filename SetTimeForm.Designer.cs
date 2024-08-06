
namespace CAL_FinalProject
{
    partial class SetTimeForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.dtpTimeSet = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnCancel.Location = new System.Drawing.Point(320, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 46);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnSet.Location = new System.Drawing.Point(71, 135);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(116, 46);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // dtpTimeSet
            // 
            this.dtpTimeSet.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpTimeSet.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dtpTimeSet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeSet.Location = new System.Drawing.Point(133, 62);
            this.dtpTimeSet.Name = "dtpTimeSet";
            this.dtpTimeSet.ShowUpDown = true;
            this.dtpTimeSet.Size = new System.Drawing.Size(244, 28);
            this.dtpTimeSet.TabIndex = 3;
            // 
            // SetTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAL_FinalProject.Properties.Resources.crystal;
            this.ClientSize = new System.Drawing.Size(507, 243);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.dtpTimeSet);
            this.Name = "SetTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetTimeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.DateTimePicker dtpTimeSet;
    }
}