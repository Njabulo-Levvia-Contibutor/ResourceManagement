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
    public partial class Form1 : Form
    {
        DBAccess ObjdbAccess = new DBAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //
        private void button1_Click(object sender, EventArgs e)
        {
            string employeeid = txtemployeeid.Text;
            string firstname = txtfirstname.Text;
            string lastname = txtlastname.Text;
            string primaryoffering = txtprimaryoffering.Text;
            string secondaryoffering = txtsecondaryoffering.Text;

            //

            if (employeeid.Equals(""))
            {
                MessageBox.Show("Please enter employeeid");
            }
            else if (firstname.Equals(""))
            {
                MessageBox.Show("Please enter firstname");
            }
            else if (lastname.Equals(""))
            {
                MessageBox.Show("Please enter lastname");
            }
            else if (primaryoffering.Equals(""))
            {
                MessageBox.Show("Please enter primaryoffering");
            }
            else if (secondaryoffering.Equals(""))
            {
                MessageBox.Show("Please enter secondaryoffering");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO EMPLOYEE(EmployeeID,FirstName,LastName,PrimaryOffering,SecondaryOffering) values(@employeeid,@firstname,@lastname,@primaryoffering,@secondaryoffering)");
                insertCommand.Parameters.AddWithValue("@employeeid", employeeid);
                insertCommand.Parameters.AddWithValue("@firstname", firstname);
                insertCommand.Parameters.AddWithValue("@lastname", lastname);
                insertCommand.Parameters.AddWithValue("@primaryoffering", primaryoffering);
                insertCommand.Parameters.AddWithValue("@secondaryoffering", secondaryoffering);

                //
                int row = ObjdbAccess.executeQuery(insertCommand);

                if (row == 1)
                    {
                    MessageBox.Show("Information recorded successful ");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error occured. Please try agaian");
                    
                }
            }
        }
    }
}
