using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;





namespace WinFormsApp1
{
    public partial class SignUp : Form
    {   
        DBAccess ObjdbAccess = new DBAccess();
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            string employeeid = txtEmpleeID.Text;
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string primaryoffering = txtPrimaryOffering.Text;
            string secondaryoffering = txtSecondaryOffering.Text;

            if (employeeid.Equals(""))
            {
                MessageBox.Show("Please enter your EmployeeID");
            }
           else  if (firstname.Equals(""))
            {
                MessageBox.Show("Please enter your FirstName");
            }
            else if (lastname.Equals(""))
            {
                MessageBox.Show("Please enter your LastName");
            }
            else if (primaryoffering.Equals(""))
            {
                MessageBox.Show("Please enter your PrimaryOffering");
            }
            else if (secondaryoffering.Equals(""))
            {
                MessageBox.Show("Please enter your SecondaryOffering");
            }
            else
            {

                SqlCommand instertCommand = new SqlCommand("insert into Employee(EmployeeID,FirstName,LastName,PrimaryOffering,SecondaryOffering) values(@employeeid,@firstname,@lastname,@primaryoffering,@secondaryoffering)");
                instertCommand.Parameters.AddWithValue("@employeeid", employeeid);
                instertCommand.Parameters.AddWithValue("@firstname", firstname);
                instertCommand.Parameters.AddWithValue("@lastname", lastname);
                instertCommand.Parameters.AddWithValue("@primaryoffering", primaryoffering);
                instertCommand.Parameters.AddWithValue("@secondaryoffering", secondaryoffering);

                int V = ObjdbAccess.executeQuery(instertCommand);
               

                if (V == 1)
                {
                    MessageBox.Show("Information recorded Successfuly");
                    this.Hide();
                    SecondPage second = new SecondPage();
                    second.Show();
                }
                else
                {
                    MessageBox.Show("Error Occured. Try Again");
                }
            }
        }
    }
}
