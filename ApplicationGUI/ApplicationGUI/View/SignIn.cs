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
namespace ApplicationGUI
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {       }

        private void label1_Click(object sender, EventArgs e)
        {        }            
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }
        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {                    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string role = PersonDL.SearchRoleInList(name, password);
            if (role != null)
            {
                role = role.ToLower();

                if (PersonDL.CheckIFNameIsPresent(name))
                {
                    MessageBox.Show("User Present as " + role);
                    ClearData();
                    if (role == "admin")
                    {
                        AdminMenu admin = new AdminMenu();
                        admin.Show();
                    }
                    else if (role == "customer")
                    {
                        CustomerMenu customer = new CustomerMenu();
                        customer.Show();
                    }
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("User Not Present");             
                this.Hide();
            }
        }
    }
}
