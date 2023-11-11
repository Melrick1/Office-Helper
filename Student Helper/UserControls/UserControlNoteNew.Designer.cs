namespace Student_Helper
{
    partial class UserControlNoteNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlNoteNew));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.Location = new System.Drawing.Point(3, 128);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.ReadOnly = true;
            this.TitleBox.Size = new System.Drawing.Size(144, 19);
            this.TitleBox.TabIndex = 2;
            this.TitleBox.Text = "New Note";
            this.TitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TitleBox.DoubleClick += new System.EventHandler(this.TitleBox_DoubleClick);
            this.TitleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TitleBox_KeyDown);
            this.TitleBox.Leave += new System.EventHandler(this.TitleBox_Leave);
            // 
            // UserControlNoteNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlNoteNew";
            this.Load += new System.EventHandler(this.NewNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TitleBox;
    }
}
