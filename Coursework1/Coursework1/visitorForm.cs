using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class visitorForm : Form
    {
        public visitorForm()
        {
            InitializeComponent();
            loadgrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            //try and catch block to handle the exception
            try
            {
                //passing fields data into new variable
                int visitorID = int.Parse(id_txt.Text);
                string visitorName = name_txt.Text;
                string visitorAge = "";
                string group = (string)grpMembers_dropdown.SelectedItem;
                var dateTime = DateTime.Now;
                var Date = dateTime.ToLongDateString();
                var visitDate = dateTimePicker.Value.ToLongDateString();
                int number = int.Parse(number_txt.Text);
                string day = "";
                string duration = (string)duration_txt.SelectedItem;
                string status = "";
                //setting the respective value of radio button when respective radio button for age is pressed
                if (childRadioBtn.Checked)
                {
                    visitorAge = "Child";
                }
                if (adultRadioBtn.Checked)
                {
                    visitorAge = "Adult";
                }
                if (agedRadioBtn.Checked)
                {
                    visitorAge = "Aged";
                }
                //setting the respective value of radio button when respective radio button for day is pressed
                if (weekdayRadioBtn.Checked)
                {
                    day = "Weekday";
                }
                if (weekendRadioBtn.Checked)
                {
                    day = "Weekend";
                }
                //setting the respective value of radio button when respective radio button for status is pressed
                if (checkedInRadioBtn.Checked)
                {
                    status = "Checked In";
                }
                if (checkedOutRadioBtn.Checked)
                {
                    status = "Checked Out";
                }
                var entryTime = "";
                if (status.Equals("Checked In"))
                {
                    entryTime = dateTime.ToShortTimeString();
                }
                var exitTime = "";
                if (status.Equals("Checked Out"))
                {
                    exitTime = dateTime.ToShortTimeString();
                }
                //creating Visitor type object
                Visitor v;
                v = new Visitor();
                //passing visitor details to methods in Visitor file
                v.VisitorID = visitorID;
                v.VisitorName = visitorName;
                v.VisitorAgeGroup = visitorAge;
                v.Group = group;
                v.Date = visitDate;
                v.VisitorNumber = number;
                v.Day = day;
                v.Duration = duration;
                v.Status = status;
                v.EntryTime = entryTime;
                v.ExitTime = exitTime;
                validation(v);
            }
            //throwing exception message when try block does not executes
            catch (Exception)
            {
                MessageBox.Show("Fields are reqired");
            }
        }

        private void validation(Visitor v)
        {
            //checking if VisitorID is not equal to null
            if (!v.VisitorID.Equals(""))
            {
                //checking if VisitorName is not equal to null
                if (!v.VisitorName.Equals(""))
                {
                    //checking if VisitorAgeGroup is not equal to null
                    if (!v.VisitorAgeGroup.Equals(""))
                    {
                        //checking if Day is not equal to null
                        if (!v.Day.Equals(""))
                        {
                            //checking if Status is not equal to null
                            if (!v.Status.Equals(""))
                            {
                                //checking if Group is not equal to null
                                if (v.Group != null)
                                    {
                                        //checking if number_txt is not equal to null
                                        if (!v.VisitorNumber.Equals(""))
                                         {
                                            //checking if Duration is not equal to null
                                            if (v.Duration != null)
                                            {                                                   
                                                //checking if Status is not equal to Checked In
                                                if (v.Status.Equals("Checked In"))
                                                {
                                                    saveVisitor(v);
                                                }   
                                                //checking if Status is not equal to Checked Out
                                                else if (v.Status.Equals("Checked Out"))
                                                {
                                                    //checking if price is not equal to null
                                                    if (!price.Equals(""))
                                                    {
                                                     UpdateVisitor(v);
                                                    }    
                                                }
                                                
                                            }
                                        // diaplaying error message when Duration equals null value
                                        else if (v.Duration == null)
                                        {
                                            MessageBox.Show("*** Duration should be selected. ***");
                                        }

                                    }
                                        // diaplaying error message when number_txt equals null value
                                        else if (v.VisitorNumber.Equals(""))
                                        {
                                            MessageBox.Show("*** Number of visitors is required. ***");
                                        }
                                }
                                // diaplaying error message when Group equals null value
                                else if (v.Group == null)
                                {
                                    MessageBox.Show("*** Visitor group should be selected. ***");
                                }
                            }                              // diaplaying error message when Status equals null value
                            else if (v.Status.Equals(""))
                            {
                                 MessageBox.Show("*** Status radio button should be selected. ***");
                            }
                        }
                        // diaplaying error message when Day equals null value
                        else if (v.Day.Equals(""))
                        {
                            MessageBox.Show("*** Day radio button should be selected. ***");
                        }
                    }
                    // diaplaying error message when VisitorAgeGroup equals null value
                    else if (v.VisitorAgeGroup.Equals(""))
                    {
                        MessageBox.Show("*** Visitor age radio button should be selected. ***");
                    }

                }
                // diaplaying error message when VisitorName equals null value
                else if (v.VisitorName.Equals(""))
                {
                    MessageBox.Show("*** Visitor name is required. ***");
                }

            }
            // diaplaying error message when VisitorID equals null value
            else if (v.VisitorID.Equals(""))
            {
                MessageBox.Show("*** Visitor ID is required. ***");
            }
        }


        private List<Visitor> listOfVisitor()
        {
            //method to read list of visitors from visitorUtility file
            List<Visitor> lstVisitor = new List<Visitor>();
            string data = visitorUtility.ReadFromFile();
            if (data != null && data != "")
            {
                lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(data);
            }
            return lstVisitor;
        }

        private void saveVisitor(Visitor v)
        {
            List<Visitor> lstVisitor;
            lstVisitor = listOfVisitor();
            foreach (Visitor i in lstVisitor)
            {
                //checking if the visitor id in visitorUtility file equals to inserted visitorID
                if (i.VisitorID.Equals(v.VisitorID))
                {
                    //diaplaying error message when visitor Id is already taken
                    MessageBox.Show("*** Please enter new id. ***" + "\n" + "Visitor ID:" 
                        + v.VisitorID + " has been already taken.");
                    return;
                }
            }
            string visitorNum = number_txt.Text;
            int VisitorNumber = int.Parse(visitorNum);
            v.VisitorNumber = VisitorNumber;
            lstVisitor.Add(v);
            writeVisitor(lstVisitor);
            //displaying success message when visitor details are saved.
            MessageBox.Show("Details saved");
            loadgrid();
            v.run();
        }

        private void writeVisitor(List<Visitor> lstVisitor)
        {
            //method to write in visitorUtility file
            String str = JsonConvert.SerializeObject(lstVisitor);
            visitorUtility.WriteToText(str);
        }

        private void UpdateVisitor(Visitor v)
        {
            List<Visitor> a = listOfVisitor();
            // setting false boolean value to chkID and visitorStatus
            Boolean chkID = false;
            Boolean visitorStatus = false;
            foreach (Visitor i in a)
            {
                //checking if visitor id exists in visiyorUtility file list
                if (i.VisitorID.Equals(v.VisitorID))
                {
                    //checking if the visitor has checked in or not.
                    if (i.Status.Equals("Checked In"))
                    {
                        //setting values for price and visitor status 
                        v.Price = double.Parse(price.Text);
                        v.Status = "Checked Out";
                        v.EntryTime = i.EntryTime;
                        v.VisitorNumber = i.VisitorNumber;
                        a.Remove(i);
                        a.Add(v);
                        //writing price in visitorUtility file
                        writeVisitor(a);
                        chkID = false;
                        visitorStatus = false;
                        //displaying the updated value in message dialog box
                        MessageBox.Show(
                            "Details are updated as:" + "\n" + "Visitor Name = " + v.VisitorName + "\n" + "Age Group = " + v.VisitorAgeGroup + "\n" +
                            "Number of visitors = " + v.VisitorNumber + "\n" + "Group of = " + v.Group + "/n" + "Date = " + v.Date + "/n" +
                            "Day = " + v.Day + "\n" + "Status = " + v.Status + "Price = " + v.Price + "\n" + "Checked In Time = " + v.EntryTime
                            + "\n" + "Checked Out Time = " + v.ExitTime);
                    }
                    //setting visitor status value true when visitor status is not equal to Checked In
                    else
                    {
                        chkID = false;
                        visitorStatus = true;
                    }
                    break;
                }
                //setting chkID value true when visitor id does not match with the list of visitors in visitorUtility file
                else
                {
                    chkID = true;
                }
            }
            //displaying error message when visitor has not checked in
            if (chkID == true)
            {
                MessageBox.Show("Sorry Visitor has not checked in.");
                return;
            }
            //displaying error message when visitor has already checked out
            if (visitorStatus == true)
            {
                MessageBox.Show("Sorry Visitor has already checked out.");
                return;
            }
        }

        public void loadgrid()
        {
            //reading visitor details from visitorUtility file and passing the data source to grid view
            string datas = visitorUtility.ReadFromFile();
            List<Visitor> list = new List<Visitor>();
            list = JsonConvert.DeserializeObject<List<Visitor>>(datas);
            dataGridView.DataSource = list;
        }

        private void refreshGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //loading grid data when refresh menu option is clicked
            loadgrid();
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showing DailyReport from when daily report menu option is clicked
            DailyReport d = new DailyReport();
            d.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //calling login function when log out menu option is clicked
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        //clearing all the field of visitor form
        public void clear()
        {
            //clearing all fields of the form
            id_txt.Text = "";
            name_txt.Text = "";
            childRadioBtn.Checked = false;
            adultRadioBtn.Checked = false;
            agedRadioBtn.Checked = false;
            grpMembers_dropdown.SelectedIndex = -1;
            grpMembers_dropdown.Text = "-- GROUP MEMBERS --";
            number_txt.Text = "";
            dateTimePicker.Text = "";
            weekdayRadioBtn.Checked = false;
            weekendRadioBtn.Checked = false;
            duration_txt.SelectedIndex = -1;
            duration_txt.Text = "-- SELECT DURATION --";
            checkedInRadioBtn.Checked = false;
            checkedOutRadioBtn.Checked = false;
            price.Text = "";
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            //calling clear method to clear all the fields of form
            clear();
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            //if condition to check if passed value in id text field is integer
            if (System.Text.RegularExpressions.Regex.IsMatch(id_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter integer value only.");
            }
        }

        private void number_txt_TextChanged(object sender, EventArgs e)
        {
            //if condition to check if passed value in id text field is integer
            if (System.Text.RegularExpressions.Regex.IsMatch(number_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter integer value only.");
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            //if condition to check if passed value in price text field is integer
            if (System.Text.RegularExpressions.Regex.IsMatch(price.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter integer value only.");
            }
        }
        
        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            //checking if the entered value in the name text field are string or not
            if (System.Text.RegularExpressions.Regex.IsMatch(name_txt.Text, "[^A-Z][^a-z]"))
            {
                MessageBox.Show("Please enter string value only.");
            }
        }

        
    }
}
