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
    public partial class SearchBusByDate : Form
    {
        public SearchBusByDate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = textBox1.Text;
            Bus bus = BusDL.SearchBusByDate(date);
            if (bus != null)
            {
                label4.Text = bus.GetBusNumber();
                label5.Text = bus.GetTiming();
                label6.Text = bus.GetRoute();
            }
            else
            {
                MessageBox.Show("Bus Not Present");
            }
            AdminMenu form = new AdminMenu();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu form = new AdminMenu();
            this.Hide();
            form.Show();
        }
    }
}
