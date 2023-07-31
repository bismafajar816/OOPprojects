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
    public partial class UpdateBus : Form
    {
        public UpdateBus()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string path = "Bus.txt";
            string serial = textBox1.Text;
            string route = textBox2.Text;
            Bus bus = BusDL.SearchBusBySerial(serial);
            if (bus != null)
            {
                BusDL.UpdateBus(serial, bus.GetRoute(), route);
                BusDL.StoreData(path);
                MessageBox.Show("Bus route Updated");
            }
            else
            {
                MessageBox.Show("Bus Not Present");
            }
            this.Hide();
        }
    }
}
