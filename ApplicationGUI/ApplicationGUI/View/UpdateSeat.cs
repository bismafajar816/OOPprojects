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
    public partial class UpdateSeat : Form
    {
        public UpdateSeat()
        {
            InitializeComponent();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int num = int.Parse(textBox2.Text);
            int updated = int.Parse(textBox3.Text);
            bool flag = CustomerDL.CheckIfCustomerIsPresent(name);
            bool flag2 = CustomerDL.CheckIfSpecificSeatIsREserved(name, num);
            if (flag2 == true && flag == true)
            {
                bool flag3 = CustomerDL.UpdateSeatNumber(num, updated);
                if (flag3)
                {
                    MessageBox.Show("Seat Updated");
                    CustomerDL.StoreData("Customer.txt");
                }
            }
            else
            {
                MessageBox.Show("Invalid data we cannot find it in our record");
            }
            this.Hide();
        }
    }
}
