namespace Student_Helper
{
    partial class ToDoForm
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
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.buttonToDo = new System.Windows.Forms.Button();
            this.buttonReminder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.ToDoListView = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchedule.Location = new System.Drawing.Point(36, 177);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(125, 35);
            this.buttonSchedule.TabIndex = 0;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendar.Location = new System.Drawing.Point(36, 381);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(125, 35);
            this.buttonCalendar.TabIndex = 7;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotes.Location = new System.Drawing.Point(36, 330);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(125, 35);
            this.buttonNotes.TabIndex = 5;
            this.buttonNotes.Text = "Notes";
            this.buttonNotes.UseVisualStyleBackColor = true;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // buttonToDo
            // 
            this.buttonToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToDo.Location = new System.Drawing.Point(36, 279);
            this.buttonToDo.Name = "buttonToDo";
            this.buttonToDo.Size = new System.Drawing.Size(125, 35);
            this.buttonToDo.TabIndex = 6;
            this.buttonToDo.Text = "To-Do List";
            this.buttonToDo.UseVisualStyleBackColor = true;
            this.buttonToDo.Click += new System.EventHandler(this.buttonToDo_Click);
            // 
            // buttonReminder
            // 
            this.buttonReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReminder.Location = new System.Drawing.Point(36, 228);
            this.buttonReminder.Name = "buttonReminder";
            this.buttonReminder.Size = new System.Drawing.Size(125, 35);
            this.buttonReminder.TabIndex = 4;
            this.buttonReminder.Text = "Reminder";
            this.buttonReminder.UseVisualStyleBackColor = true;
            this.buttonReminder.Click += new System.EventHandler(this.buttonReminder_Click);
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
            this.panel1.Size = new System.Drawing.Size(199, 681);
            this.panel1.TabIndex = 16;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(213, 83);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(504, 20);
            this.TitleBox.TabIndex = 20;
            this.TitleBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(213, 124);
            this.DescBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(1042, 20);
            this.DescBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Description:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Title:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(833, 158);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(253, 31);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(525, 158);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(253, 31);
            this.buttonEdit.TabIndex = 28;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // ToDoListView
            // 
            this.ToDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToDoListView.BackgroundColor = System.Drawing.Color.White;
            this.ToDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoListView.Location = new System.Drawing.Point(213, 206);
            this.ToDoListView.Margin = new System.Windows.Forms.Padding(2);
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.RowHeadersWidth = 51;
            this.ToDoListView.RowTemplate.Height = 24;
            this.ToDoListView.Size = new System.Drawing.Size(1040, 466);
            this.ToDoListView.TabIndex = 30;
            this.ToDoListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(213, 158);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(253, 31);
            this.NewButton.TabIndex = 31;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Due - Date:";
            // 
            // DueBox
            // 
            this.DueBox.Location = new System.Drawing.Point(745, 83);
            this.DueBox.Margin = new System.Windows.Forms.Padding(2);
            this.DueBox.Name = "DueBox";
            this.DueBox.Size = new System.Drawing.Size(510, 20);
            this.DueBox.TabIndex = 32;
            this.DueBox.Text = "Day-Month-Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(648, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "To Do List";
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DueBox);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.ToDoListView);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.panel1);
            this.Name = "ToDoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ToDoForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    

        #endregion

        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.Button buttonToDo;
        private System.Windows.Forms.Button buttonReminder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView ToDoListView;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DueBox;
        private System.Windows.Forms.Label label4;
    }
}