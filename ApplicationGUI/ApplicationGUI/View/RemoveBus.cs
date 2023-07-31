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
    public partial class RemoveBus : Form
    {
        public RemoveBus()
        {
            InitializeComponent();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            string path = "Bus.txt";
            bool flag = BusDL.RemoveBus(serial);
            if (flag)
            {
                MessageBox.Show("Bus Removed");
            }
            else
            {
                MessageBox.Show("Bus Not present");
            }
            BusDL.StoreData(path);

            this.Hide();
        }
    }
}
