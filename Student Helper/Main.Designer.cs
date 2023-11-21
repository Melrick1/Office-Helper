namespace Student_Helper
{
    partial class Main
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
            this.dataSet1 = new System.Data.DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutBtn = new System.Windows.Forms.Button();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.buttonToDo = new System.Windows.Forms.Button();
            this.buttonReminder = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.OutBtn);
            this.panel1.Controls.Add(this.buttonCalendar);
            this.panel1.Controls.Add(this.buttonNotes);
            this.panel1.Controls.Add(this.buttonToDo);
            this.panel1.Controls.Add(this.buttonReminder);
            this.panel1.Controls.Add(this.buttonSchedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 681);
            this.panel1.TabIndex = 15;
            // 
            // OutBtn
            // 
            this.OutBtn.BackColor = System.Drawing.Color.DarkMagenta;
            this.OutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutBtn.ForeColor = System.Drawing.Color.White;
            this.OutBtn.Location = new System.Drawing.Point(0, 568);
            this.OutBtn.Name = "OutBtn";
            this.OutBtn.Size = new System.Drawing.Size(250, 50);
            this.OutBtn.TabIndex = 4;
            this.OutBtn.Text = "Log-out";
            this.OutBtn.UseVisualStyleBackColor = false;
            this.OutBtn.Click += new System.EventHandler(this.OutBtn_Click);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendar.ForeColor = System.Drawing.Color.White;
            this.buttonCalendar.Location = new System.Drawing.Point(0, 381);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(250, 50);
            this.buttonCalendar.TabIndex = 3;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = false;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotes.ForeColor = System.Drawing.Color.White;
            this.buttonNotes.Location = new System.Drawing.Point(0, 330);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(250, 50);
            this.buttonNotes.TabIndex = 2;
            this.buttonNotes.Text = "Notes";
            this.buttonNotes.UseVisualStyleBackColor = false;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // buttonToDo
            // 
            this.buttonToDo.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToDo.ForeColor = System.Drawing.Color.White;
            this.buttonToDo.Location = new System.Drawing.Point(0, 279);
            this.buttonToDo.Name = "buttonToDo";
            this.buttonToDo.Size = new System.Drawing.Size(250, 50);
            this.buttonToDo.TabIndex = 2;
            this.buttonToDo.Text = "To-Do List";
            this.buttonToDo.UseVisualStyleBackColor = false;
            this.buttonToDo.Click += new System.EventHandler(this.buttonToDo_Click);
            // 
            // buttonReminder
            // 
            this.buttonReminder.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReminder.ForeColor = System.Drawing.Color.White;
            this.buttonReminder.Location = new System.Drawing.Point(0, 228);
            this.buttonReminder.Name = "buttonReminder";
            this.buttonReminder.Size = new System.Drawing.Size(250, 50);
            this.buttonReminder.TabIndex = 1;
            this.buttonReminder.Text = "Reminder";
            this.buttonReminder.UseVisualStyleBackColor = false;
            this.buttonReminder.Click += new System.EventHandler(this.buttonReminder_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchedule.ForeColor = System.Drawing.Color.White;
            this.buttonSchedule.Location = new System.Drawing.Point(0, 177);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(250, 50);
            this.buttonSchedule.TabIndex = 0;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = false;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 681);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Student-Helper | Schedule";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.Button buttonToDo;
        private System.Windows.Forms.Button buttonReminder;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OutBtn;
    }
}

