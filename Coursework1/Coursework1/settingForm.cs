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
    public partial class settingForm : Form
    {
        public settingForm()
        {
            InitializeComponent();
            loadgrid();
        }
        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            //try and catch block to handle the exception
            try
            {
                //passing fields data into new variable
                int id = int.Parse(id_txt.Text);
                string group = (string)grpMembers_dropdown.SelectedItem;
                string day = "";
                string ageGroup = "";
                string duration = (string)duration_txt.SelectedItem;
                double ticketPrice = double.Parse(price_txt.Text);
                //setting the respective value of radio button when respective radio button for age is pressed
                if (childRadioBtn.Checked)
                {
                    ageGroup = "Child";
                }
                if (adultRadioBtn.Checked)
                {
                    ageGroup = "Adult";
                }
                if (agedRadioBtn.Checked)
                {
                    ageGroup = "Aged";
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
                //creating Visitor type object
                Settings s;
                s = new Settings();
                //passing visitor details to methods in Visitor file
                s.TicketID = id;
                s.AgeGroup = ageGroup;
                s.Group = group;
                s.Day = day;
                s.Duration = duration;
                s.Price = ticketPrice;
                validation(s);
            }
            //throwing exception message when try block does not executes
            catch (Exception)
            {
                MessageBox.Show("All fields are required.");
            }
        }


        private void gridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //showing DailyReport from when daily report menu option is clicked
            WeeklyReportGrid wg = new WeeklyReportGrid();
            wg.Show();
        }


        private void validation(Settings s)
        {
            //checking if TicketID is not equal to null
            if (!s.TicketID.Equals(""))
            {
                //checking if AgeGroup is not equal to null
                if (!s.AgeGroup.Equals(""))
                {
                    //checking if Day is not equal to null
                    if (!s.Day.Equals(""))
                    {
                        //checking if Duration is not equal to null
                        if (s.Duration != null)
                        {
                            if (s.Group != null)
                            {
                                //checking if Price is not equal to null
                                if (!s.Price.Equals(""))
                                {
                                    //passing the data to saveSetting method
                                    saveSetting(s);
                                }
                                // diaplaying error message when Price equals null value
                                else if (s.Price.Equals(""))
                                {
                                    MessageBox.Show("*** Price is required. ***");
                                }
                            }
                            // diaplaying error message when Duration equals null value
                            else if (s.Group == null)
                            {
                                MessageBox.Show("*** Group should be selected. ***");
                            }
                        }
                       // diaplaying error message when Duration equals null value
                        else if (s.Duration == null)
                        {
                            MessageBox.Show("*** Duration should be selected. ***");
                        }
                    }
                    // diaplaying error message when Day equals null value
                    else if (s.Day.Equals(""))
                    {
                        MessageBox.Show("*** Day should be selected. ***");
                    }
                }
                // diaplaying error message when AgeGroup equals null value
                else if (s.AgeGroup.Equals(""))
                {
                    MessageBox.Show("*** Age group should be selected. ***");
                }
            }
            // diaplaying error message when TicketID equals null value
            else if (s.TicketID.Equals(""))
            {
                MessageBox.Show("*** Ticket ID is required. ***");
            }
        }                
 
        private List<Settings> listOfTicket()
        {
            //method to read list of visitors from visitorUtility file
            string x = settingUtility.ReadFromFile();
            List<Settings> ticketList = new List<Settings>();
            if (x != null && x != "")
            {
                ticketList = JsonConvert.DeserializeObject<List<Settings>>(x);
            }
            return ticketList;
        }

        private void saveSetting(Settings s)
        {
            List<Settings> ticketList;
            ticketList = listOfTicket();
            foreach (Settings i in ticketList)
            {
                //checking if the visitor id in visitorUtility file equals to inserted visitorID
                if (i.TicketID.Equals(s.TicketID))
                {
                    //diaplaying error message when visitor Id is already taken
                    MessageBox.Show("****** SORRY *******" + "\n" 
                        + "\n" + "Ticket ID = " + s.TicketID 
                        + " has been taken.");
                    return;
                }
            }
            string ticketPrice = price_txt.Text;
            double Price = double.Parse(ticketPrice, CultureInfo.InvariantCulture.NumberFormat);
            s.Price = Price;
            ticketList.Add(s);
            writeTicket(ticketList);
            //displaying success message when visitor details are saved.
            MessageBox.Show("Details saved");
            loadgrid();
            s.run();
        }
        private void writeTicket(List<Settings> lstTicket)
        {
            //method to write in visitorUtility file
            String str = JsonConvert.SerializeObject(lstTicket);
            settingUtility.WriteToText(str);
        }

        public void loadgrid()
        {
            // setting false boolean value to chkID and visitorStatus
            string str = settingUtility.ReadFromFile();
            List<Settings> list = new List<Settings>();
            list = JsonConvert.DeserializeObject<List<Settings>>(str);
            settingGridView.DataSource = list;
        }

        private void duration_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
             
           
        }

        private void visitorFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showing visitorForm from when visitor form report menu option is clicked
            visitorForm v = new visitorForm();
            v.Show();
        }

        private void chartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //showing WeeklyReportChart from when visitor form chart menu option is clicked
            WeeklyReportChart wc = new WeeklyReportChart();
            wc.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //loading grid when refresh menu option is pressed
            loadgrid();
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showing DailyReport from when visitor form daily report menu option is clicked
            DailyReport d = new DailyReport();
            d.Show();

        }
        //clearing all the field of visitor form
        public void clear()
        {
            //clearing all fields of the form
            id_txt.Text = "";
            childRadioBtn.Checked = false;
            adultRadioBtn.Checked = false;
            agedRadioBtn.Checked = false;
            grpMembers_dropdown.SelectedIndex = -1;
            grpMembers_dropdown.Text = "-- GROUP MEMBERS --";
            weekdayRadioBtn.Checked = false;
            weekendRadioBtn.Checked = false;
            duration_txt.SelectedIndex = -1;
            duration_txt.Text = "-- SELECT DURATION --";
            price_txt.Text = "";
        }


        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //calling login funciton when log out menu option is clicked
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            //if condition to check if passed value in id text field is integer
            if (System.Text.RegularExpressions.Regex.IsMatch(id_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter integer value only.");
            }
        }

        
        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            //calling clear method to clear all the fileds of form
            clear();
        }

        private void grpMembers_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void price_txt_TextChanged(object sender, EventArgs e)
        {
            //if condition to check if passed value in price text field is integer
            if (System.Text.RegularExpressions.Regex.IsMatch(price_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter integer value only.");
            }
        }
    }
    }

