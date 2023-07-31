using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationGUI.BL;
using ApplicationGUI.DL;
using System.IO;
namespace ApplicationGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = "Data.txt";
            string path1 = "Staff.txt";
            string path2 = "Driver.txt";
            string path3 = "Bus.txt";
            string path4 = "Customer.txt";
            if (PersonDL.LoadData(path) && StaffDL.LoadData(path1) && DriverDL.LoadDriversData(path2) && BusDL.LoadData(path3) && CustomerDL.LoadData(path4))
            {
                /*MessageBox.Show("Data loaded");
                MessageBox.Show(BusDL.busesList[0].GetBusNumber());*/              
            }
            else
            {
                MessageBox.Show("Data not loaded");
            }
            Application.Run(new Form1());
         
        }
    }
}
