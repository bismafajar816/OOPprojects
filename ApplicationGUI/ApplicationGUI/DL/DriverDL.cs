using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationGUI.BL;
using ApplicationGUI.DL;
using System.IO;
namespace ApplicationGUI.DL
{
    class DriverDL
    {
        private static List<Driver> driversList = new List<Driver>();

        internal static List<Driver> DriversList { get => driversList; set => driversList = value; }

        public static bool LoadDriversData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string name = dataParse(line, 1);
                    string password = dataParse(line, 2);
                    string Role = dataParse(line, 3);
                    string contact = dataParse(line, 4);
                    string address = dataParse(line, 5);
                    string ID = dataParse(line, 6);
                    string Rank = dataParse(line, 7);
                    string DutyTime = dataParse(line, 8);
                    string License = dataParse(line, 9);
                    Driver person = new Driver(name, password, Role, contact, address, ID, Rank, DutyTime, License);
                    DriverDL.AddToList(person);
                }
                file.Close();
                return true;
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
            return false;
        }
        public static string dataParse(string line, int field)
        {
            string item = "";
            int commacount = 1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    commacount++;
                }
                else if (commacount == field)
                {
                    item = item + line[i];
                }
            }
            return item;
        }
        public static void StoreData(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (var x in DriversList)
            {
                file.WriteLine(x.GetName() + "," + x.GetPassword() + "," + x.GetRole() + "," + x.GetContact() + "," + x.GetAddress() + "," + x.GetID() + "," + x.GetRank() + "," + x.GetDutyTime() + "," + x.GetLicenseNumber());
            }
            file.Flush();
            file.Close();
        }
        public static void AddToList(Driver p)
        {
            if (p.GetName() != "" && p.GetPassword() != "" && p.GetRole() != "")
            {
                DriversList.Add(p);
            }

        }
        public static Driver SearchEmployee(string name)
        {
            foreach (var x in DriversList)
            {
                if (x.GetName() == name)
                {
                    return x;
                }
            }
            return null;
        }
        public static void RemoveEmployee(string name, string rank)
        {

            for (int x = 0; x < DriversList.Count(); x++)
            {
                if (DriversList[x].GetName() == name && DriversList[x].GetRank() == rank)
                {
                    DriversList.RemoveAt(x);
                }
            }
        }
        public static void UpdateEmployee(string name, string updatedName, string rank, string ID)
        {
            for (int x = 0; x < DriversList.Count; x++)
            {
                if (DriversList[x].GetName() == name && DriversList[x].GetRank() == rank && DriversList[x].GetID() == ID)
                {
                    DriversList[x].SetName(updatedName);
                }
            }
        }
        public static double GetTotalIncome()
        {
            double charges = 0;
            foreach (var x in DriversList)
            {
                charges = x.GetPay();
            }
            foreach (var x in StaffDL.EmployeesList)
            {
                charges = x.GetPay();
            }
            return charges;
        }
    }
}
