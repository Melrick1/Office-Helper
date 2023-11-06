namespace Student_Helper
{
    partial class NotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.buttonToDo = new System.Windows.Forms.Button();
            this.buttonReminder = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.NotesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.NotesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.buttonCalendar);
            this.panel1.Controls.Add(this.buttonNotes);
            this.panel1.Controls.Add(this.buttonToDo);
            this.panel1.Controls.Add(this.buttonReminder);
            this.panel1.Controls.Add(this.buttonSchedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 838);
            this.panel1.TabIndex = 1;
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Location = new System.Drawing.Point(25, 345);
            this.buttonCalendar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(135, 38);
            this.buttonCalendar.TabIndex = 3;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.Location = new System.Drawing.Point(25, 293);
            this.buttonNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(135, 38);
            this.buttonNotes.TabIndex = 2;
            this.buttonNotes.Text = "Notes";
            this.buttonNotes.UseVisualStyleBackColor = true;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // buttonToDo
            // 
            this.buttonToDo.Location = new System.Drawing.Point(25, 241);
            this.buttonToDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToDo.Name = "buttonToDo";
            this.buttonToDo.Size = new System.Drawing.Size(135, 38);
            this.buttonToDo.TabIndex = 2;
            this.buttonToDo.Text = "To-Do List";
            this.buttonToDo.UseVisualStyleBackColor = true;
            this.buttonToDo.Click += new System.EventHandler(this.buttonToDo_Click);
            // 
            // buttonReminder
            // 
            this.buttonReminder.Location = new System.Drawing.Point(25, 190);
            this.buttonReminder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReminder.Name = "buttonReminder";
            this.buttonReminder.Size = new System.Drawing.Size(135, 38);
            this.buttonReminder.TabIndex = 1;
            this.buttonReminder.Text = "Reminder";
            this.buttonReminder.UseVisualStyleBackColor = true;
            this.buttonReminder.Click += new System.EventHandler(this.buttonReminder_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(25, 138);
            this.buttonSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(135, 38);
            this.buttonSchedule.TabIndex = 0;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1061, 66);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 757);
            this.vScrollBar1.TabIndex = 8;
            // 
            // NotesContainer
            // 
            this.NotesContainer.BackColor = System.Drawing.Color.Gray;
            this.NotesContainer.Controls.Add(this.pictureBox1);
            this.NotesContainer.Location = new System.Drawing.Point(225, 66);
            this.NotesContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NotesContainer.Name = "NotesContainer";
            this.NotesContainer.Size = new System.Drawing.Size(832, 757);
            this.NotesContainer.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.NotesContainer);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NotesForm";
            this.Text = "Student-Helper | Notes";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.panel1.ResumeLayout(false);
            this.NotesContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.Button buttonToDo;
        private System.Windows.Forms.Button buttonReminder;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel NotesContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}