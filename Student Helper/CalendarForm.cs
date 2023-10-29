using MySqlX.XDevAPI.Relational;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class CalendarForm : Form
    {
        static DateTime currentDT = DateTime.Now;
        public static int currentYear = currentDT.Year;
        public static int currentMonth = currentDT.Month;

        public CalendarForm()
        {
            InitializeComponent();
        }

        //Load
        private void CalendarForm_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        
        //calendar
        private void displayDays()
        {
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);
            labelMonth.Text = monthname + " " + currentYear;

            DateTime startofthemonth = new DateTime(currentYear, currentMonth, 1);

            int days = DateTime.DaysInMonth(currentYear, currentMonth);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlEmpty UCBlank = new UserControlEmpty();
                dayContainer.Controls.Add(UCBlank);  
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDay UCDays = new UserControlDay();
                UCDays.days(i);
                UCDays.displayEvent(i);
                dayContainer.Controls.Add(UCDays);
            }
        }

        //Next Button
        private void NextBtn_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            if (currentMonth == 12)
            {
                currentMonth = 0;
                currentYear++;
            }
            currentMonth++;
            displayDays();
        }

        //Prev Button
        private void PrevBtn_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            if (currentMonth == 1)
            {
                currentMonth = 13;
                currentYear--;
            }
            currentMonth--;
            displayDays();
           
        }

        //Menu Buttons
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
