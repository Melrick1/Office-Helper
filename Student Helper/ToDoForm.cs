using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleForm ScheduleForm = new ScheduleForm();
            ScheduleForm.Show();
        }

        private void buttonReminder_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotesForm NotesForm = new NotesForm();
            NotesForm.Show();
        }

        private void buttonToDo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ToDoForm ToDoForm = new ToDoForm();
            ToDoForm.Show();
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotesForm NotesForm = new NotesForm();
            NotesForm.Show();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalendarForm CalendarForm = new CalendarForm();
            CalendarForm.Show();
        }
    }
}
