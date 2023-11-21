namespace Student_Helper
{
    partial class TabReminder
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
            this.CalendarReminder = new System.Windows.Forms.Label();
            this.ToDoReminder = new System.Windows.Forms.Label();
            this.DataCalendar = new System.Windows.Forms.DataGridView();
            this.dataToDo = new System.Windows.Forms.DataGridView();
            this.NotesReminder = new System.Windows.Forms.Label();
            this.NotesContainer = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DataCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataToDo)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarReminder
            // 
            this.CalendarReminder.AutoSize = true;
            this.CalendarReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarReminder.Location = new System.Drawing.Point(3, 373);
            this.CalendarReminder.Name = "CalendarReminder";
            this.CalendarReminder.Size = new System.Drawing.Size(96, 24);
            this.CalendarReminder.TabIndex = 0;
            this.CalendarReminder.Text = "Calendar :";
            // 
            // ToDoReminder
            // 
            this.ToDoReminder.AutoSize = true;
            this.ToDoReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoReminder.Location = new System.Drawing.Point(3, 15);
            this.ToDoReminder.Name = "ToDoReminder";
            this.ToDoReminder.Size = new System.Drawing.Size(72, 24);
            this.ToDoReminder.TabIndex = 1;
            this.ToDoReminder.Text = "To Do :";
            // 
            // DataCalendar
            // 
            this.DataCalendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCalendar.Location = new System.Drawing.Point(7, 400);
            this.DataCalendar.Name = "DataCalendar";
            this.DataCalendar.Size = new System.Drawing.Size(491, 262);
            this.DataCalendar.TabIndex = 4;
            // 
            // dataToDo
            // 
            this.dataToDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataToDo.Location = new System.Drawing.Point(7, 51);
            this.dataToDo.Name = "dataToDo";
            this.dataToDo.Size = new System.Drawing.Size(491, 266);
            this.dataToDo.TabIndex = 5;
            // 
            // NotesReminder
            // 
            this.NotesReminder.AutoSize = true;
            this.NotesReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesReminder.Location = new System.Drawing.Point(602, 15);
            this.NotesReminder.Name = "NotesReminder";
            this.NotesReminder.Size = new System.Drawing.Size(134, 24);
            this.NotesReminder.TabIndex = 6;
            this.NotesReminder.Text = "Recent Notes :";
            // 
            // NotesContainer
            // 
            this.NotesContainer.BackColor = System.Drawing.Color.Gray;
            this.NotesContainer.Location = new System.Drawing.Point(606, 51);
            this.NotesContainer.Name = "NotesContainer";
            this.NotesContainer.Padding = new System.Windows.Forms.Padding(3);
            this.NotesContainer.Size = new System.Drawing.Size(378, 611);
            this.NotesContainer.TabIndex = 13;
            // 
            // TabReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NotesContainer);
            this.Controls.Add(this.NotesReminder);
            this.Controls.Add(this.dataToDo);
            this.Controls.Add(this.DataCalendar);
            this.Controls.Add(this.ToDoReminder);
            this.Controls.Add(this.CalendarReminder);
            this.Name = "TabReminder";
            this.Size = new System.Drawing.Size(1014, 681);
            this.Load += new System.EventHandler(this.TabReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataToDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalendarReminder;
        private System.Windows.Forms.Label ToDoReminder;
        private System.Windows.Forms.DataGridView DataCalendar;
        private System.Windows.Forms.DataGridView dataToDo;
        private System.Windows.Forms.Label NotesReminder;
        private System.Windows.Forms.FlowLayoutPanel NotesContainer;
    }
}
