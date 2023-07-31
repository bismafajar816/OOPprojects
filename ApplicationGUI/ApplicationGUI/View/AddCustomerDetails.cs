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
    public partial class AddCustomerDetails : Form
    {
        public AddCustomerDetails()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string path = "Customer.txt";
            string serial = textBox7.Text;
            string name = textBox1.Text;
            string password = textBox2.Text;
            string contact = textBox3.Text;
            string address = textBox4.Text;
            int seats = int.Parse(textBox5.Text);
            int number = 0;
            List<int> seatList = new List<int>();
            if (seats == 1)
            {
                if (textBox6.Text != " ")
                {
                    number = int.Parse(textBox6.Text);
                    if (CustomerDL.CheckIfSeatIsReserved(number, serial))
                    {
                        MessageBox.Show("Cannot select this seat");
                        textBox6.Text = " ";
                    }
                    else
                    {
                        seatList.Add(number);
                        textBox6.Text = " ";
                    }
                }
                if (number == 0)
                {
                    int number2 = int.Parse(textBox9.Text);

                    if (CustomerDL.CheckIfSeatIsReserved(number2, serial))
                    {
                        MessageBox.Show("Cannot select this seat");
                        textBox9.Text = " ";
                    }
                    else
                    {
                        seatList.Add(number2);
                        textBox9.Text = " ";
                    }
                }
            }
            else if (seats == 2)
            {
                number = int.Parse(textBox6.Text);
                if (CustomerDL.CheckIfSeatIsReserved(number, serial))
                {
                    textBox6.Text = " ";
                    MessageBox.Show("Cannot select this seat");
                }
                else
                {
                    textBox6.Text = " ";
                    seatList.Add(number);
                }
                int number2 = int.Parse(textBox9.Text);

                if (CustomerDL.CheckIfSeatIsReserved(number2, serial))
                {
                    MessageBox.Show("Cannot select this seat");
                    textBox9.Text = " ";
                }
                else
                {
                    textBox9.Text = " ";
                    seatList.Add(number2);
                }
            }
            else
            {
                MessageBox.Show("Cannot select this number of seats");
            }
            string payment = textBox8.Text.ToLower();
            double charges = GetPayment(payment, seats);
            if (seatList.Count != 0)
            {
                if (charges != 0)
                {
                    Customer customer = new Customer(name, password, "customer", contact, address, charges, seatList, serial);
                    CustomerDL.AddCustomerToList(customer);
                    CustomerDL.StoreData(path);
                    MessageBox.Show("Seat reserved");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Invalid Input ");
                    ClearData();

                }
            }         
            ClearText();
            this.Hide();
        }
        private double GetPayment(string type, int number)
        {
            if (type == "cash")
            {
                MessageBox.Show("Your payable amount is  rupees : " + 1500 * number);
                return 1500 * number;
            }
            else if (type == "card")
            {
                MessageBox.Show("Your payable amount is  rupees: " + 1425 * number);
                return 1425 * number;
            }
            else
            {
                MessageBox.Show("Invalid method");
            }
            return 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {        }
        private void AddCustomerDetails_Load(object sender, EventArgs e)
        {        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {        }
        private void label9_Click(object sender, EventArgs e)
        {        }
        private void ClearText()
        {
            textBox1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string serial = textBox7.Text;
            bool bus = BusDL.CheckBusBySerial(serial);
            if (bus)
            {
                MessageBox.Show("Bus Is Selected");
               
            }
            else
            {
                MessageBox.Show(" Bus Cannot Be Selected");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMenu menu = new CustomerMenu();
            menu.Show();
            ClearText();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {        }
    }
}
