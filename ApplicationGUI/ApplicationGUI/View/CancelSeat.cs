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
    public partial class CancelSeat : Form
    {
        public CancelSeat()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int seta = int.Parse(textBox2.Text);
            if (CustomerDL.CancelSeat(name, seta))
            {
                MessageBox.Show("Cancelled & 50% refund will be transferred to you ");
                CustomerDL.StoreData("Customer.txt");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
            this.Hide();
        }
    }
}
