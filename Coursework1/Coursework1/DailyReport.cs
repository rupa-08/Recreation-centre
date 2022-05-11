using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Coursework1
{
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
            loadGridView();
        }

        private void loadGridView()
        {
            //reading the data from visitorUtility file and converting it to list
            string str = visitorUtility.ReadFromFile();
            List<Visitor> lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(str);
            //exception hamdling if there is no visitor list
            try
            {
                //query to genrate daily report which is grouped by visitor age group and group
                var queryData = lstVisitor.Where(x => x.Date == (dailyReportDateTimePicker.Value.ToLongDateString())).
                GroupBy(x => new { x.VisitorAgeGroup, x.Group }).Select(
                    y => new
                    {
                        Date = dailyReportDateTimePicker.Value.ToLongDateString(),
                        VisitorAgeGroup = y.Key.VisitorAgeGroup,
                        Group = y.Key.Group,
                        Total_Visitor = y.Sum(i => i.VisitorNumber),
                        Total_Income = y.Sum(i => i.Price),
                    })
                .OrderBy(x => x.VisitorAgeGroup).ToList();
                //adding total visitor, income and date to grid 
                dailyReportGridView.DataSource = queryData;
                dailyReportGridView.Columns[0].Width = 300;
                dailyReportGridView.Columns[1].Width = 300;
                dailyReportGridView.Columns[2].Width = 300;
                dailyReportGridView.Columns[3].Width = 300;
            }
            catch (Exception)
            {
                //displaying message dialog box when the try block coes not executes
                MessageBox.Show("Sorry the visitor list doesn't exists.");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //calling loadGridView method on date value change
            loadGridView();
        }
    }
}
