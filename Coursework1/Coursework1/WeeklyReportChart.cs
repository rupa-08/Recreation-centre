using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class WeeklyReportChart : Form
    {
        public WeeklyReportChart()
        {
            InitializeComponent();
            getDatesOfWeek();
            LoadChart();
        }
        //creating getter and setter method of startDate
        private String startDate { get; set; }
        //creating getter and setter method of endDate
        private String endDate { get; set; }
        public void LoadChart()
        {
            //reading the data from visitorUtility file and converting it to list
            string data = visitorUtility.ReadFromFile();
            List<Visitor> visitorList = JsonConvert.DeserializeObject<List<Visitor>>(data);
            //query to genrate weekly report
            var groupedData = visitorList.Where(obj => Convert.ToDateTime(obj.Date) >= Convert.ToDateTime(startDate) &&
                                Convert.ToDateTime(obj.Date) <= Convert.ToDateTime(endDate)).GroupBy(a => a.Date).Select(n => new
                                {Date = n.Key, TotalVisitor = n.Sum(x => x.VisitorNumber),TotalEarning = n.Sum(x => x.Price)}
                                ).OrderBy(a => a.Date);
            //adding the query output of total earning, visitor to chart
            weeklyChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            weeklyChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            weeklyChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            weeklyChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            weeklyChart.Series["Earning"].IsValueShownAsLabel = true;
            weeklyChart.Series["Earning"].XValueMember = "Date";
            weeklyChart.Series["Earning"].YValueMembers = "TotalEarning";
            weeklyChart.Series["Visitor numbers"].IsValueShownAsLabel = true;
            weeklyChart.Series["Visitor numbers"].XValueMember = "Date";
            weeklyChart.Series["Visitor numbers"].YValueMembers = "TotalVisitor";
            weeklyChart.DataSource = groupedData;
        }
        private void getDatesOfWeek()
        {
            DateTime date = dateTimePicker.Value;
            int year = date.Date.Year;
            //set the first day of the year
            DateTime firstDay = new DateTime(year, 1, 1);
            //get Day of the week 
            DayOfWeek day = date.DayOfWeek;
            CultureInfo cul = CultureInfo.CurrentCulture;
            //get no of week for the date
            int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            //get no of day
            int days = (weekNo - 1) * 7;
            DateTime dt1 = firstDay.AddDays(days);
            DayOfWeek dow = dt1.DayOfWeek;
            DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
            DateTime endDateOfWeek = startDateOfWeek.AddDays(6);
            startDate = startDateOfWeek.ToLongDateString();
            endDate = endDateOfWeek.ToLongDateString();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //calling grid method and week dates methods
            getDatesOfWeek();
            LoadChart();
        }
    }
}
