namespace Student_Helper
{
    partial class TabNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabNotes));
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.NotesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TrashBtn = new System.Windows.Forms.PictureBox();
            this.SelectCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.SortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrashBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(397, 28);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(101, 24);
            this.RefreshBtn.TabIndex = 10;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // NotesContainer
            // 
            this.NotesContainer.BackColor = System.Drawing.Color.Gray;
            this.NotesContainer.Location = new System.Drawing.Point(3, 58);
            this.NotesContainer.Name = "NotesContainer";
            this.NotesContainer.Padding = new System.Windows.Forms.Padding(3);
            this.NotesContainer.Size = new System.Drawing.Size(624, 606);
            this.NotesContainer.TabIndex = 12;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(630, 67);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 597);
            this.vScrollBar1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TrashBtn
            // 
            this.TrashBtn.Image = ((System.Drawing.Image)(resources.GetObject("TrashBtn.Image")));
            this.TrashBtn.Location = new System.Drawing.Point(597, 22);
            this.TrashBtn.Name = "TrashBtn";
            this.TrashBtn.Size = new System.Drawing.Size(30, 30);
            this.TrashBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TrashBtn.TabIndex = 13;
            this.TrashBtn.TabStop = false;
            this.TrashBtn.Click += new System.EventHandler(this.TrashBtn_Click);
            // 
            // SelectCheckBox
            // 
            this.SelectCheckBox.AutoSize = true;
            this.SelectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCheckBox.Location = new System.Drawing.Point(504, 30);
            this.SelectCheckBox.Name = "SelectCheckBox";
            this.SelectCheckBox.Size = new System.Drawing.Size(87, 22);
            this.SelectCheckBox.TabIndex = 14;
            this.SelectCheckBox.Text = "Select All";
            this.SelectCheckBox.UseVisualStyleBackColor = true;
            this.SelectCheckBox.CheckedChanged += new System.EventHandler(this.SelectCheckBox_CheckedChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(3, 28);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(175, 24);
            this.SearchBox.TabIndex = 15;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(3, 7);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(63, 18);
            this.searchLbl.TabIndex = 16;
            this.searchLbl.Text = "Search :";
            // 
            // SortBox
            // 
            this.SortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortBox.FormattingEnabled = true;
            this.SortBox.Location = new System.Drawing.Point(206, 26);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(157, 26);
            this.SortBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sort by :";
            // 
            // TabNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SelectCheckBox);
            this.Controls.Add(this.TrashBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.NotesContainer);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "TabNotes";
            this.Size = new System.Drawing.Size(1014, 681);
            this.Load += new System.EventHandler(this.TabNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrashBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.FlowLayoutPanel NotesContainer;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox TrashBtn;
        private System.Windows.Forms.CheckBox SelectCheckBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.ComboBox SortBox;
        private System.Windows.Forms.Label label1;
    }
}
