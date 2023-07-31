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
    public partial class SelectBus : Form
    {
        public SelectBus()
        {
            InitializeComponent();
        }
     

        private void SelectBus_Load(object sender, EventArgs e)
        {

        }
        private void ClearText()
        {
            textBox1.Text = "";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string serial;
            serial = textBox1.Text;
            Bus bus = BusDL.SearchBusBySerial(serial);
            if (bus != null)
            {
                MessageBox.Show("Bus Is Selected");
            }
            else
            {
                MessageBox.Show(" Bus Cannot Be Selected");
            }
            ClearText();
            this.Hide();
  
        }
    }
}
