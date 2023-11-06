namespace Student_Helper
{
    partial class Add_Notes
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
            this.label2 = new System.Windows.Forms.Label();
            this.NewNotesTxt = new System.Windows.Forms.TextBox();
            this.AddEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Title :";
            // 
            // NewNotesTxt
            // 
            this.NewNotesTxt.Location = new System.Drawing.Point(45, 83);
            this.NewNotesTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NewNotesTxt.Name = "NewNotesTxt";
            this.NewNotesTxt.Size = new System.Drawing.Size(277, 22);
            this.NewNotesTxt.TabIndex = 8;
            this.NewNotesTxt.Text = "New Note";
            // 
            // AddEvent
            // 
            this.AddEvent.Location = new System.Drawing.Point(235, 134);
            this.AddEvent.Margin = new System.Windows.Forms.Padding(4);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(87, 31);
            this.AddEvent.TabIndex = 6;
            this.AddEvent.Text = "Add";
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // Add_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 178);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewNotesTxt);
            this.Controls.Add(this.AddEvent);
            this.Name = "Add_Notes";
            this.Text = "Add_Notes";
            this.Load += new System.EventHandler(this.Add_Notes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewNotesTxt;
        private System.Windows.Forms.Button AddEvent;
    }
}