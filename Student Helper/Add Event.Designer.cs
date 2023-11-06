namespace Student_Helper
{
    partial class Add_Event
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
            this.AddEvent = new System.Windows.Forms.Button();
            this.DateTxt = new System.Windows.Forms.TextBox();
            this.EventTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEvent
            // 
            this.AddEvent.Location = new System.Drawing.Point(168, 184);
            this.AddEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(87, 31);
            this.AddEvent.TabIndex = 0;
            this.AddEvent.Text = "Add";
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // DateTxt
            // 
            this.DateTxt.Location = new System.Drawing.Point(39, 63);
            this.DateTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.ReadOnly = true;
            this.DateTxt.Size = new System.Drawing.Size(277, 22);
            this.DateTxt.TabIndex = 1;
            // 
            // EventTxt
            // 
            this.EventTxt.Location = new System.Drawing.Point(42, 132);
            this.EventTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EventTxt.Name = "EventTxt";
            this.EventTxt.Size = new System.Drawing.Size(277, 22);
            this.EventTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Event";
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.Location = new System.Drawing.Point(263, 184);
            this.DeleteEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(87, 31);
            this.DeleteEvent.TabIndex = 5;
            this.DeleteEvent.Text = "Delete";
            this.DeleteEvent.UseVisualStyleBackColor = true;
            this.DeleteEvent.Click += new System.EventHandler(this.DeleteEvent_Click);
            // 
            // Add_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 228);
            this.Controls.Add(this.DeleteEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventTxt);
            this.Controls.Add(this.DateTxt);
            this.Controls.Add(this.AddEvent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Add_Event";
            this.Text = "Add_Event";
            this.Load += new System.EventHandler(this.Add_Event_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEvent;
        private System.Windows.Forms.TextBox DateTxt;
        private System.Windows.Forms.TextBox EventTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteEvent;
    }
}