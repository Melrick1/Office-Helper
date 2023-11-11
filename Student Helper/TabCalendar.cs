using System;
using System.Globalization;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class TabCalendar : UserControl
    {
        public static DateTime currentDate = DateTime.Now;  //current Date (dd/mm/yyyy)
        public static int currentYear = currentDate.Year;   //current Date (yyyy)
        public static int currentMonth = currentDate.Month; //current Date (mm)
        public TabCalendar()
        {
            InitializeComponent();
        }
        private void TabCalendar_Load(object sender, EventArgs e)
        {
            displayDays();

            for (int i = 1900; i <= 2100; i++) 
            { 
                YearSelector.Items.Add(i);
            }
        }

        private void displayDays()
        {
            dayContainer.Controls.Clear();

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);
            labelMonth.Text = monthname + " " + currentYear;

            DateTime startofthemonth = new DateTime(currentYear, currentMonth, 1);

            int days = DateTime.DaysInMonth(currentYear, currentMonth);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            //("d") = shortest form of date

            int maxdisplay = 35;
            int totaldisplay = 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                CalendarEmptyCell UserControlBlank = new CalendarEmptyCell();
                dayContainer.Controls.Add(UserControlBlank);
                totaldisplay++;
            }

            for (int i = 1; i <= days; i++)
            {
                CalendarDayCell UserControlDate = new CalendarDayCell();
                UserControlDate.days(i);
                UserControlDate.calendarDisplayEvent(i);
                dayContainer.Controls.Add(UserControlDate);
                totaldisplay++;
            }

            int amountleft = (maxdisplay - totaldisplay) + 1;

            for (int j = 1; j <= amountleft; j++)
            {
                CalendarEmptyCell UserControlBlank = new CalendarEmptyCell();
                dayContainer.Controls.Add(UserControlBlank);
            }
        }

        //Next Button
        private void NextBtn_Click(object sender, EventArgs e)
        {
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
            if (currentMonth == 1)
            {
                currentMonth = 13;
                currentYear--;
            }
            currentMonth--;
            displayDays();
        }

        private void MonthSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Convert String month to Int month
            DateTime date = DateTime.ParseExact(MonthSelector.Text, "MMMM", null); 
            currentMonth = date.Month;
            displayDays();
        }

        private void YearSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentYear = Convert.ToInt32(YearSelector.Text);
            displayDays();
        }
    }
}
