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
    public partial class ViewBusForCustomer : Form
    {
        public ViewBusForCustomer()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = StaffDL.EmployeesList;
            foreach (Bus s in BusDL.busesList)
            {
                dataGridView1.DataSource = BusDL.busesList.Select(c => new { c.BusNumber1, c.Date1, c.Route, c.Timing1 }).ToList();
            }
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ViewBusForCustomer_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
