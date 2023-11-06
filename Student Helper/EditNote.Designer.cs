namespace Student_Helper
{
    partial class EditNote
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
            this.EditNotesTxt = new System.Windows.Forms.TextBox();
            this.AddEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title :";
            // 
            // EditNotesTxt
            // 
            this.EditNotesTxt.Location = new System.Drawing.Point(34, 67);
            this.EditNotesTxt.Name = "EditNotesTxt";
            this.EditNotesTxt.Size = new System.Drawing.Size(209, 20);
            this.EditNotesTxt.TabIndex = 12;
            // 
            // AddEvent
            // 
            this.AddEvent.Location = new System.Drawing.Point(176, 109);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(65, 25);
            this.AddEvent.TabIndex = 13;
            this.AddEvent.Text = "Edit";
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // EditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 145);
            this.Controls.Add(this.AddEvent);
            this.Controls.Add(this.EditNotesTxt);
            this.Controls.Add(this.label2);
            this.Name = "EditNote";
            this.Text = "Edit Note";
            this.Load += new System.EventHandler(this.EditNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditNotesTxt;
        private System.Windows.Forms.Button AddEvent;
    }
}