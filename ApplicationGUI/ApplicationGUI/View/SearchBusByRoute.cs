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
    public partial class SearchBusByRoute : Form
    {
        public SearchBusByRoute()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string route = textBox1.Text;
            Bus bus = BusDL.SearchBusByRoute(route);
            if (bus != null)
            {
                label4.Text = bus.GetBusNumber();
                label5.Text = bus.GetTiming();
                label6.Text = bus.GetDate();
            }
            else
            {
                MessageBox.Show("Bus Not Present");
            }
         
            this.Hide();
        
        }
    }
}
