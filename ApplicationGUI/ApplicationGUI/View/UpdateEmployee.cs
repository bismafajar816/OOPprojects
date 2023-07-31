using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationGUI.BL;
using ApplicationGUI.DL;
using System.IO;
namespace ApplicationGUI
{
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string path = "Driver.txt";
            string path2 = "Staff.txt";
            string name = textBox1.Text;
            string Updated = textBox2.Text;
            if (checkBox1.Checked)
            {
                Driver driver = DriverDL.SearchEmployee(name);
                if (driver != null)
                {
                    DriverDL.UpdateEmployee(name, Updated, driver.GetRank(), driver.GetID());
                    DriverDL.StoreData(path);
                    MessageBox.Show("Driver Updated");
                }
                else
                {
                    MessageBox.Show("User Not Present");
                }
            }
            else
            {
                Staff staff = StaffDL.SearchEmployee(name);
                if (staff != null)
                {

                    StaffDL.UpdateEmployee(name, Updated, staff.GetRank(), staff.GetID());
                    StaffDL.StoreData(path2);
                    MessageBox.Show("Employee Updated");
                }
                else
                {
                    MessageBox.Show("User Not Present");
                }
            }

            this.Hide();
        }
    }
}
