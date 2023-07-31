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
    public partial class AdminMenu : Form
    {
        Form currentChildForm;
        public AdminMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.Show();
        }
        private void AdminMenu_Load(object sender, EventArgs e)
        {        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {        }
        private void button2_Click(object sender, EventArgs e)
        {                   }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Left;
            childPanel.Controls.Add(childForm);
            childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string type = comboBox1.Text.ToLower();
            comboBox1.ResetText();
            if (type == "driver")
            {
                comboBox1.Text = " ";
                AddDriver add = new AddDriver();
                OpenChildForm(add);
              
            }
            else if(type == "employee")
            {
                comboBox1.Text = " ";
                AddStaff add = new AddStaff();
                OpenChildForm(add);
            }
            else
            {
                comboBox1.Text = " ";
                AddBus add = new AddBus();
                OpenChildForm(add);
            }
            comboBox1.Text = " ";
        }
        private void label3_Click(object sender, EventArgs e)
        {                   }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox2.Text.ToLower();
         
            if (type == "driver")
            {
                RemoveStaff staff = new RemoveStaff();
                OpenChildForm(staff);
                comboBox2.Text = " ";

            }
            else if (type == "employee")
            {
                RemoveStaff staff = new RemoveStaff();
                OpenChildForm(staff);
                comboBox2.Text = " ";
            }
            else
            {
                RemoveBus bus = new RemoveBus();
                OpenChildForm(bus);
                comboBox2.Text = " ";
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox3.Text.ToLower();
            
            if (type == "driver")
            {
                UpdateEmployee staff = new UpdateEmployee();
                OpenChildForm(staff);
                comboBox3.Text = " ";

            }
            else if (type == "employee")
            {
                UpdateEmployee staff = new UpdateEmployee();
                OpenChildForm(staff);
                comboBox3.Text = " ";
            }
            else
            {
                UpdateEmployee staff = new UpdateEmployee();
                OpenChildForm(staff);
                comboBox3.Text = " ";
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox4.Text.ToLower();
           
            if (type == "employee")
            {
                ViewStaff view = new ViewStaff();
                OpenChildForm(view);

            }
            else if(type == "driver")
            {
                ViewDriver view = new ViewDriver();
                OpenChildForm(view);
            }
            else if(type == "bus")
            {
                ViewBus bus = new ViewBus();
                OpenChildForm(bus);
            }
            else
            {
                double money = StaffDL.GetIncome();
                MessageBox.Show("Total income after subtracting staff pay and bus charges is : "+money.ToString());
            }
        }
        private void label1_Click(object sender, EventArgs e)
        { }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();

        }
        private void label4_Click(object sender, EventArgs e)
        {        }
    }
}
