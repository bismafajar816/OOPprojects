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
    public partial class CustomerMenu : Form
    {
        Form currentChildForm;
        public CustomerMenu()
        {
            InitializeComponent();
        }
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
            ChildPanel.Controls.Add(childForm);
            ChildPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void CustomerMenu_Load(object sender, EventArgs e)
        {        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox2.Text.ToLower();
            if(type == "add")
            {
                AddCustomerDetails customer = new AddCustomerDetails();
                OpenChildForm(customer);          
            }
            else if(type == "update")
            {
                UpdateSeat seat = new UpdateSeat();
                OpenChildForm(seat);
          
            }
            else if(type == "cancel")
            {
                CancelSeat seat = new CancelSeat();
                OpenChildForm(seat);
           
            }
            else if(type == "refund")
            {
                CancelSeat seat = new CancelSeat();
                OpenChildForm(seat);
             
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            this.Hide();
            sign.Show();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox3.Text.ToLower();
            if (type == "bus")
            {
                ViewBusForCustomer view = new ViewBusForCustomer();
                OpenChildForm(view);
            }
        }
    }
}
