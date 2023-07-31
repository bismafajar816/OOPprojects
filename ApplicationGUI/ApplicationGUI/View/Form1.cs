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
    public partial class Form1 : Form
    {
        Form currentChildForm;
        public Form1()
        {
            InitializeComponent();           
        }
        private void Form1_Load(object sender, EventArgs e)
        {             }

        private void label1_Click(object sender, EventArgs e)
        {   }       
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }      
        private void pictureBox1_Click(object sender, EventArgs e)
        {        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void ChildPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            OpenChildForm(sign);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            OpenChildForm(signIn);
          
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ForgotPassword password = new ForgotPassword();
            OpenChildForm(password);
        }
    }
}
