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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {        }
        private void button2_Click(object sender, EventArgs e)
        {       }
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";            
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string path = "Staff.txt";
            string name = textBox1.Text;
            string password = textBox2.Text;
            string role = "driver";
            string contact = textBox3.Text;
            string address = textBox4.Text;
            string ID = textBox5.Text;
            string rank = textBox6.Text;
            string dutyTime = textBox7.Text;

            Staff staff = new Staff(name, password, role, contact, address, ID, rank, dutyTime);

            if (name != "")
            {
                StaffDL.AddToList(staff);
                MessageBox.Show("Employee added");
                StaffDL.StoreData(path);
                ClearData();
                this.Hide();
            }
            this.Hide();
        }
    }
}
