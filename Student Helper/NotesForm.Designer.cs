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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.buttonToDo = new System.Windows.Forms.Button();
            this.buttonReminder = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.NotesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 609);
            this.panel1.TabIndex = 1;
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Location = new System.Drawing.Point(19, 280);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(101, 31);
            this.buttonCalendar.TabIndex = 3;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.Location = new System.Drawing.Point(19, 238);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(101, 31);
            this.buttonNotes.TabIndex = 2;
            this.buttonNotes.Text = "Notes";
            this.buttonNotes.UseVisualStyleBackColor = true;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // buttonToDo
            // 
            this.buttonToDo.Location = new System.Drawing.Point(19, 196);
            this.buttonToDo.Name = "buttonToDo";
            this.buttonToDo.Size = new System.Drawing.Size(101, 31);
            this.buttonToDo.TabIndex = 2;
            this.buttonToDo.Text = "To-Do List";
            this.buttonToDo.UseVisualStyleBackColor = true;
            this.buttonToDo.Click += new System.EventHandler(this.buttonToDo_Click);
            // 
            // buttonReminder
            // 
            this.buttonReminder.Location = new System.Drawing.Point(19, 154);
            this.buttonReminder.Name = "buttonReminder";
            this.buttonReminder.Size = new System.Drawing.Size(101, 31);
            this.buttonReminder.TabIndex = 1;
            this.buttonReminder.Text = "Reminder";
            this.buttonReminder.UseVisualStyleBackColor = true;
            this.buttonReminder.Click += new System.EventHandler(this.buttonReminder_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(19, 112);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(101, 31);
            this.buttonSchedule.TabIndex = 0;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(796, 54);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 615);
            this.vScrollBar1.TabIndex = 8;
            // 
            // NotesContainer
            // 
            this.NotesContainer.BackColor = System.Drawing.Color.Gray;
            this.NotesContainer.Location = new System.Drawing.Point(169, 54);
            this.NotesContainer.Name = "NotesContainer";
            this.NotesContainer.Size = new System.Drawing.Size(624, 615);
            this.NotesContainer.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(169, 17);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(101, 31);
            this.RefreshBtn.TabIndex = 4;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.NotesContainer);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.Name = "NotesForm";
            this.Text = "Student-Helper | Notes";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button RefreshBtn;
    }
}