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
    public partial class ViewBus : Form
    {
        public ViewBus()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = StaffDL.EmployeesList;
            foreach (Bus s in BusDL.busesList)
            {
                dataGridView1.DataSource = BusDL.busesList.Select(c => new { c.BusNumber1,c.Date1,c.Route,c.Timing1 }).ToList();
            }
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int index = e.RowIndex;
                string name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                BusDL.RemoveBus(name);
                BusDL.StoreData("Bus.txt");
                DataBind();
                this.Hide();
            }
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int index = e.RowIndex;
                string name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                UpdateBus bus = new UpdateBus();
                bus.ShowDialog();
                BusDL.StoreData("Bus.txt");
                DataBind();
                this.Hide();
            }
        }
        private void ViewBus_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
