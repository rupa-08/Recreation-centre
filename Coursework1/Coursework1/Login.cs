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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click_1(object sender, EventArgs e)
        {
            // creating two local variable
            String name, password;
            //passing text field data in the local variable
            name = userName_txt.Text;
            password = password_txt.Text;
            //checking user name is admin and password as password
            if (name == "admin" && password == "password")
            {
                //showing setting form when user is admin
                settingForm s = new settingForm();
                s.Show();
                this.Hide();
            }
            //checking user name name is staff and password as password
            else if (name == "staff" && password == "password")
            {
                //showing visitor form when user is staff
                visitorForm v = new visitorForm();
                v.Show();
                this.Hide();
            }
            else if (name == "" && password == "")
            {
                //displaying warning message when fields are empty
                MessageBox.Show(" !! WARNING Fields are empty.\n Please enter data in the field.");
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
            //diaplaying error message when name and password is not equal to required user name or password
            else if (name != "staff" || name != "admin" && password != "password")
            {
                MessageBox.Show("!! Error. Incorrect values provided.");
            }
        }
    }
}
