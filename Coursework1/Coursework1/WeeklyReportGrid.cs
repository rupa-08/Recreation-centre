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
    public partial class WeeklyReportGrid : Form
    {
        public WeeklyReportGrid()
        {
            InitializeComponent();
            getDatesOfWeek();
            LoadGrid(reports());
            comboBox.SelectedIndex = 0;
        }
        //creating getter and setter method of startDate
        private String startDate { get; set; }
        //creating getter and setter method of endDate
        private String endDate { get; set; }

        private void LoadGrid(List<Report> reports)
        {
            //adding the query (groupedData) output of total earning, visitor and date to grid 
            dataGridView.DataSource = reports;
            dataGridView.Columns[0].Width = 240;
            dataGridView.Columns[1].Width = 240;
            dataGridView.Columns[2].Width = 240;
        }

        private List<Report> reports()
        {
            //reading the data from visitorUtility file and converting it to list
            string data = visitorUtility.ReadFromFile();
            List<Visitor> visitorList = JsonConvert.DeserializeObject<List<Visitor>>(data);

            Console.WriteLine(Convert.ToDateTime(startDate));
            Console.WriteLine(DateTime.Parse(startDate));
            //query to genrate weekly report
            var groupedData = visitorList.Where(obj => Convert.ToDateTime(obj.Date) >= Convert.ToDateTime(startDate) &&
                              Convert.ToDateTime(obj.Date) <= Convert.ToDateTime(endDate)).GroupBy(a => a.Date).Select
                              (n => new{Date = n.Key,Visitors = n.Sum(x => x.VisitorNumber),Income = n.Sum(x => x.Price)}
                              ).OrderBy(a => a.Date).ToList();
            //creating list of from Report class
            List<Report> reports = new List<Report>();
            foreach (var datas in groupedData)
            {
                Report report = new Report();
                report.Visit_Date = datas.Date;
                report.Total_Visitors = datas.Visitors;
                report.Total_Income = datas.Income;
                reports.Add(report);
            }
            return reports;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //calling grid method and week dates methods
            getDatesOfWeek();
            LoadGrid(reports());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //calling total visitor list in ascending order when index 1 is pressed in combo box
            if (comboBox.SelectedIndex == 1)
            {
                totalVisitorAsc();
                
            }
            //calling total visitor list in descending order when index 2 is pressed in combo box
            else if (comboBox.SelectedIndex == 2)
            {
                totalVisitorDesc();              
            }
            //calling total earning list in ascending order when index 3 is pressed in combo box
            else if (comboBox.SelectedIndex == 3)
            {
                totalEarningDesc();
            }
            //calling total earning list in ascending order when index 4 is pressed in combo box
            else if (comboBox.SelectedIndex == 4)
            {
                totalEarningAsc();
            }
        }

        private void totalVisitorAsc()
        {
            //creating object of Report class
            Report report = new Report();
            List<Report> reportList = report.visitorAsc(reports());
            //passing the total visitor ascending as list to the LoadGrid method
            LoadGrid(reportList);
        }

        private void totalVisitorDesc()
        {
            //creating object of Report class
            Report report = new Report();
            List<Report> reportList = report.visitorDesc(reports());
            //passing the total visitor descending as list to the LoadGrid method
            LoadGrid(reportList);
        }

        private void totalEarningAsc()
        {
            //creating object of Report class
            Report report = new Report();
            List<Report> reportList = report.earningAsc(reports());
            //passing the total earning ascending as list to the LoadGrid method
            LoadGrid(reportList);
        }

        private void totalEarningDesc()
        {
            //creating object of Report class
            Report report = new Report();
            List<Report> reportList = report.earningDesc(reports());
            //passing the total earning descending as list to the LoadGrid method
            LoadGrid(reportList);
        }
    }
}
