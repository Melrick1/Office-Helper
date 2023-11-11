namespace Student_Helper
{
    partial class AddNote
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
            this.AddNoteTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNoteTxt
            // 
            this.AddNoteTxt.Location = new System.Drawing.Point(34, 67);
            this.AddNoteTxt.Name = "AddNoteTxt";
            this.AddNoteTxt.Size = new System.Drawing.Size(209, 20);
            this.AddNoteTxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Title :";
            // 
            // AddEvent
            // 
            this.AddEvent.Location = new System.Drawing.Point(178, 108);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(65, 25);
            this.AddEvent.TabIndex = 15;
            this.AddEvent.Text = "Add";
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 145);
            this.Controls.Add(this.AddEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddNoteTxt);
            this.Name = "AddNote";
            this.Text = "Add a New Note";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddNoteTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddEvent;
    }
}