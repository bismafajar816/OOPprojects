﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationGUI.BL;
using ApplicationGUI.DL;
using System.IO;
namespace ApplicationGUI.DL
{
    class StaffDL
    {
        public static List<Staff> EmployeesList = new List<Staff>();
        public static void AddToList(Staff staff)
        {
            EmployeesList.Add(staff);
        }
        public static Staff SearchEmployee(string name)
        {
            foreach (var x in EmployeesList)
            {
                if (x.GetName() == name)
                {
                    return x;
                }
            }
            return null;
        }
        public static void DeleteEmployee(Staff s)
        {
            EmployeesList.Remove(s);
        }
        public static void RemoveEmployee(string name, string rank)
        {

            for (int x = 0; x < EmployeesList.Count(); x++)
            {
                if (EmployeesList[x].GetName() == name && EmployeesList[x].GetRank() == rank)
                {
                    EmployeesList.RemoveAt(x);
                }
            }
        }
        public static void UpdateEmployee(string name, string updatedName, string rank, string ID)
        {
            foreach (var x in EmployeesList)
            {
                if (x.GetName() == name && x.GetRank() == rank && x.GetID() == ID)
                {
                    x.SetName(updatedName);
                }
            }
        }
        public static void StoreData(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (var x in EmployeesList)
            {
                file.WriteLine(x.GetName() + "," + x.GetPassword() + "," + x.GetRole() + "," + x.GetContact() + "," + x.GetAddress() + "," + x.GetID() + "," + x.GetRank() + "," + x.GetDutyTime());
            }
            file.Flush();
            file.Close();
        }
        public static bool LoadData(string path)
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

                    Staff person = new Staff(name, password, Role, contact, address, ID, Rank, DutyTime);
                    StaffDL.AddToList(person);
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

        public static double GetIncome()
        {
            double payAble = DriverDL.GetTotalIncome() + BusDL.GetPetrolPrice();
            double earned = CustomerDL.GetTotalPrice();
            double Total = earned - payAble;
            return Total;
        }
    }
}
