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
    public partial class ViewSeats : Form
    {
        public ViewSeats()
        {
            InitializeComponent();
        }
        private void DataBind(string serial)
        {

            dataGridView1.DataSource = null;
            List<Customer> customers = CustomerDL.GetSeats(serial).Select(c => new Customer { SeatNumbers1 = new List<int> { c } }).ToList();
            dataGridView1.DataSource = customers;
            //List<Customer> customers = CustomerDL.GetSeats(serial).Select(c => new Customer { SeatNumbers1 = c }).ToList();
            //dataGridView1.DataSource = CustomerDL.customersList.Select(c => new { c.GetSeats(serial) }).ToList();
            dataGridView1.Refresh();
        }
        private void ViewSeats_Load(object sender, EventArgs e)
        {
            /* DataBind()*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            DataBind(serial);
        }
    }
}
