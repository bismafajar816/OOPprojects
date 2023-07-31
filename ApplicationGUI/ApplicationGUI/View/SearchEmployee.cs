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
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void SearchEmployee_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (checkBox1.Checked)
            {
                Driver driver = DriverDL.SearchEmployee(name);
                if (driver != null)
                {
                    label3.Text = driver.GetID();
                    label4.Text = driver.GetRank();
                    label5.Text = driver.GetDutyTime();
                    label6.Text = driver.GetLicenseNumber();
                }
                else
                {
                    MessageBox.Show("Driver not available");
                }

            }
            else
            {
                Staff driver = StaffDL.SearchEmployee(name);
                if (driver != null)
                {

                    label3.Text = driver.GetID();
                    label4.Text = driver.GetRank();
                    label5.Text = driver.GetDutyTime();
                    label6.Text = "Not Available";

                }
            }
         
            this.Hide();
        
        }
    }
}
