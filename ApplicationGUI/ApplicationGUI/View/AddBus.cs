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
    public partial class AddBus : Form
    {
        public AddBus()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string path = "Bus.txt";
            string serial = textBox1.Text;
            string date = textBox2.Text;
            string route = textBox3.Text;
            string timing = textBox4.Text;
            Bus bus = new Bus(serial, timing, date, route);
            BusDL.AddBusToList(bus);
            BusDL.StoreData(path);
            MessageBox.Show("Bus Added");
            this.Hide();
        }
    }
}
