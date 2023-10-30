namespace Student_Helper
{
    partial class UserControlDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDay = new System.Windows.Forms.Label();
            this.EventLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(3, 10);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(38, 25);
            this.labelDay.TabIndex = 1;
            this.labelDay.Text = "00";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventLbl
            // 
            this.EventLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EventLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.EventLbl.Location = new System.Drawing.Point(0, 72);
            this.EventLbl.Name = "EventLbl";
            this.EventLbl.Size = new System.Drawing.Size(138, 24);
            this.EventLbl.TabIndex = 2;
            this.EventLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EventLbl);
            this.Controls.Add(this.labelDay);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(138, 96);
            this.Click += new System.EventHandler(this.UserControlDay_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label EventLbl;
        private System.Windows.Forms.Timer timer1;
    }
}
