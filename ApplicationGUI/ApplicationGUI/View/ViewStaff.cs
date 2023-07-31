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
    public partial class ViewStaff : Form
    {
        public ViewStaff()
        {
            InitializeComponent();
        }
        private void ViewStaff_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        public void DataBind()
        {
            dataGridView1.DataSource = null;        
            foreach (Staff s in StaffDL.EmployeesList)
            {
                dataGridView1.DataSource = StaffDL.EmployeesList.Select(c => new { c.Name, c.Rank, c.ID1, c.DutyTime }).ToList();
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
                StaffDL.DeleteEmployee(StaffDL.SearchEmployee(name));
                StaffDL.StoreData("Staff.txt");
                DataBind();
                this.Hide();
            }
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int index = e.RowIndex;
                string name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                UpdateEmployee employee = new UpdateEmployee();
                employee.ShowDialog();
                StaffDL.StoreData("Staff.txt");
                DataBind();
                this.Hide();
            }
        }
        private void ViewStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*  Application.Exit();*/
        }
    }
}
