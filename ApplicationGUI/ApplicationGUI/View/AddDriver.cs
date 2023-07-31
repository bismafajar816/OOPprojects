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
    public partial class AddDriver : Form
    {
        public AddDriver()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {        }
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
        private void AddDriver_Load(object sender, EventArgs e)
        {        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string path = "Driver.txt";
            string name = textBox1.Text;
            string password = textBox2.Text;
            string role = "driver";
            string contact = textBox3.Text;
            string address = textBox4.Text;
            string ID = textBox5.Text;
            string rank = textBox6.Text;
            string dutyTime = textBox7.Text;
            string licenseNumber = textBox8.Text;
            Driver driver = new Driver(name, password, role, contact, address, ID, rank, dutyTime, licenseNumber);
            if (name != "")
            {
                DriverDL.AddToList(driver);
                MessageBox.Show("Employee added");
                DriverDL.StoreData(path);
                ClearData();
                this.Hide();
            }
            this.Hide();

        }
    }
}
