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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void SignUp_Load(object sender, EventArgs e)
        {        }
        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {     }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string role = comboBox1.Text;
            role = role.ToLower();
            string path = "Data.txt";
            string contact = textBox4.Text;
            string address = textBox5.Text;
            Person person = new Person(name, password, role, contact, address);

            if (PersonDL.CheckIFNameIsPresent(name))
            {
                MessageBox.Show("Already Present User");
                this.Hide();
            }
            else
            {
                if (name != "")
                {
                    PersonDL.AddToList(person);
                    MessageBox.Show("User added");
                    if(role == "admin")
                    {
                        AdminMenu menu = new AdminMenu();
                        this.Hide();                        
                        menu.Show();
                    }
                    else if(role == "customer")
                    {
                        CustomerMenu menu = new CustomerMenu();
                        this.Hide();
                        menu.Show();
                    }
              
                    PersonDL.StoreData(path);
                    ClearData();
                    this.Hide();
                }
            }         
            this.Hide();        
        }
    }
}
