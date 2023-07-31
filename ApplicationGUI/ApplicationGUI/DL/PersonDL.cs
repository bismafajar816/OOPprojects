﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationGUI.BL;
using System.IO;
namespace ApplicationGUI.DL
{
    class PersonDL
    {
        public static List<Person> Enteries = new List<Person>();
        internal Person Person
        {
            get => default;
            set
            {
            }
        }
        public static bool CheckIFNameIsPresent(string name)
        {
            foreach (var x in Enteries)
            {
                if (x.GetName() == name)
                {
                    return true;
                }
            }
            return false;
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
                    Person person = new Person(name, password, Role, contact, address);
                    PersonDL.AddToList(person); 
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
            foreach (Person x in Enteries)
            {
                file.WriteLine(x.GetName() + "," + x.GetPassword() + "," + x.GetRole() + "," + x.GetContact() + "," + x.GetAddress());
               /* if(x is Driver) Type Casting
                {
                    Driver driver = (Driver)x;
                    file.WriteLine(x.GetName() + "," + x.GetPassword() + "," + x.GetRole() + "," + x.GetContact() + "," + x.GetAddress() + "," + driver.GetID() + "," + driver.GetRank() + "," + driver.GetDutyTime() + "," + driver.GetLicenseNumber());
                }*/
            }
            file.Flush();
            file.Close();

        }
        public static void AddToList(Person p)
        {
            if (p.GetName() != null && p.GetPassword() != null && p.GetRole() != null)
            {
                Enteries.Add(p);
            }

        }
        public static string SearchRoleInList(string name, string password)
        {
            foreach (var x in Enteries)
            {
                if (x.GetName() == name && x.GetPassword() == password)
                {
                    return x.GetRole();
                }
            }
            return null;
        }
        public static string GetPasswordByName(string name)
        {
            foreach (var x in Enteries)
            {
                if (x.GetName() == name)
                {
                    return x.GetPassword();
                }
            }
            return null;
        }
    }
}
