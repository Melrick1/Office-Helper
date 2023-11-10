using System;
using System.Globalization;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class TabCalendar : UserControl
    {
        public static DateTime currentDate = DateTime.Now;
        public static int currentYear = currentDate.Year;
        public static int currentMonth = currentDate.Month;
        public TabCalendar()
        {
            InitializeComponent();
        }
        private void TabCalendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);
            labelMonth.Text = monthname + " " + currentYear;

            DateTime startofthemonth = new DateTime(currentYear, currentMonth, 1);

            int days = DateTime.DaysInMonth(currentYear, currentMonth);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                CalendarEmptyCell UserControlBlank = new CalendarEmptyCell();
                dayContainer.Controls.Add(UserControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                CalendarDayCell UserControlDate = new CalendarDayCell();
                UserControlDate.days(i);
                UserControlDate.calendarDisplayEvent(i);
                dayContainer.Controls.Add(UserControlDate);
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
    }
}
