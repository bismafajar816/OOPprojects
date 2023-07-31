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
    public partial class ViewDriver : Form
    {
        public ViewDriver()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = StaffDL.EmployeesList;
            foreach (Driver s in DriverDL.DriversList)
            {
                dataGridView1.DataSource = DriverDL.DriversList.Select(c => new { c.Name, c.Rank, c.ID1, c.DutyTime,c.LicenseNumber1  }).ToList();
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
                Driver d = DriverDL.SearchEmployee(name);
                DriverDL.RemoveEmployee(d.Name,d.Rank);
                DataBind();
                this.Hide();
            }
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int index = e.RowIndex;
                string name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                UpdateEmployee employee = new UpdateEmployee();
                employee.ShowDialog();
                DriverDL.StoreData("Driver.txt");
                DataBind();
                this.Hide();
            }
        }
        private void ViewDriver_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
