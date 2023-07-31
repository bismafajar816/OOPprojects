using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationGUI
{
    public partial class AddStaffType : Form
    {
        public AddStaffType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu admin = new AdminMenu();
            this.Hide();
            admin.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AddDriver driver = new AddDriver();
            this.Hide();
            driver.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            AddStaff staff = new AddStaff();
            this.Hide();
            staff.Show();
        }
    }
}
