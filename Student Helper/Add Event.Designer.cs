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
            this.AddEvent.Location = new System.Drawing.Point(124, 148);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(65, 25);
            this.AddEvent.TabIndex = 0;
            this.AddEvent.Text = "Add";
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // DateTxt
            // 
            this.DateTxt.Location = new System.Drawing.Point(29, 51);
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.ReadOnly = true;
            this.DateTxt.Size = new System.Drawing.Size(209, 20);
            this.DateTxt.TabIndex = 1;
            // 
            // EventTxt
            // 
            this.EventTxt.Location = new System.Drawing.Point(29, 106);
            this.EventTxt.Name = "EventTxt";
            this.EventTxt.Size = new System.Drawing.Size(209, 20);
            this.EventTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Event";
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.Location = new System.Drawing.Point(195, 148);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(65, 25);
            this.DeleteEvent.TabIndex = 5;
            this.DeleteEvent.Text = "Delete";
            this.DeleteEvent.UseVisualStyleBackColor = true;
            this.DeleteEvent.Click += new System.EventHandler(this.DeleteEvent_Click);
            // 
            // Add_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 185);
            this.Controls.Add(this.DeleteEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventTxt);
            this.Controls.Add(this.DateTxt);
            this.Controls.Add(this.AddEvent);
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