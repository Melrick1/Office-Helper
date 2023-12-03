namespace Student_Helper
{
    partial class Report
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
            this.Back = new System.Windows.Forms.Button();
            this.pnl_child = new System.Windows.Forms.Panel();
            this.cachedCrystalReport11 = new Student_Helper.CachedCrystalReport1();
            this.crystalReport12 = new Student_Helper.CrystalReport1();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(693, 25);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(56, 19);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pnl_child
            // 
            this.pnl_child.Location = new System.Drawing.Point(11, 48);
            this.pnl_child.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_child.Name = "pnl_child";
            this.pnl_child.Size = new System.Drawing.Size(1297, 580);
            this.pnl_child.TabIndex = 1;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 639);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.pnl_child);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private CachedCrystalReport1 cachedCrystalReport11;
        private CrystalReport1 crystalReport12;
        private System.Windows.Forms.Panel pnl_child;
    }
}