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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            
        }
        private void ForgotPassword_Load(object sender, EventArgs e)
        {                  }
        private void button1_Click_1(object sender, EventArgs e)
        {                     }
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = PersonDL.GetPasswordByName(name);
            label3.Text = password;
            MessageBox.Show("You can copy your password and Sign In again");
            
        }
    }
}
