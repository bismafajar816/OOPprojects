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
    class CustomerDL
    {
        public static List<Customer> customersList = new List<Customer>();

        public static void AddCustomerToList(Customer customer)
        {
            customersList.Add(customer);
        }
        public static List<int> GetSeats(string serial)
        {
            List<int> seats = null;
            foreach (var x in customersList)
            {
                if (x.GetBusSerial() == serial)
                {
                    seats = x.GetList();

                }
            }
            return seats;


        }
        public static bool CheckIfCustomerIsPresent(string name)
        {
            bool flag = false;
            for (int x = 0; x < customersList.Count(); x++)
            {
                if (customersList[x].GetName() == name)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public static bool CancelSeat(string name, int seat)
        {
            for (int x = 0; x < customersList.Count(); x++)
            {
                for (int y = 0; y < customersList[x].GetList().Count; y++)
                {
                    if (customersList[x].GetName() == name && customersList[x].GetList()[y] == seat)
                    {
                        customersList[x].GetList().RemoveAt(y);
                        customersList[x].GetRefund(true);
                        return true;
                    }

                }
            }
            return false;
        }
        public static bool CheckIfSpecificSeatIsREserved(string name, int seat)
        {
            for (int x = 0; x < customersList.Count(); x++)
            {
                for (int y = 0; y < customersList[x].GetList().Count; y++)
                {

                    if (customersList[x].GetName() == name && customersList[x].GetList()[y] == seat)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool UpdateSeatNumber(int unChanged, int changed)
        {
            for (int x = 0; x < customersList.Count(); x++)
            {
                for (int y = 0; y < customersList[x].GetList().Count; y++)
                {

                    if (customersList[x].GetList()[y] == unChanged)
                    {
                        customersList[x].GetList()[y] = changed;
                        return true;
                    }
                }
            }

            return false;
        }
        public static bool CheckIfSeatIsReserved(int seat, string serial)
        {
            for (int x = 0; x < customersList.Count(); x++)
            {
                for (int y = 0; y < customersList[x].GetList().Count; y++)
                {

                    if (customersList[x].GetList()[y] == seat && customersList[x].GetBusSerial() == serial)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void StoreData(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            string seats = "";
            foreach (var customer in customersList)
            {
                for (int x = 0; x < customer.GetList().Count - 1; x++)
                {
                    seats = seats + customer.GetList()[x] + ";";
                }
                seats = seats + customer.GetList()[customer.GetList().Count - 1];

                file.WriteLine(customer.GetName() + "," + customer.GetPassword() + "," + customer.GetRole() + "," + customer.GetContact() + "," + customer.GetAddress() + "," + customer.GetBusSerial() + "," + customer.GetCharges() + "," + seats);
                seats = "";
            }

            file.Flush();
            file.Close();
        }
        public static bool LoadData(string path)
        {

            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');

                    string Name = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    string contact = splittedRecord[3];
                    string address = splittedRecord[4];
                    string serial = splittedRecord[5];
                    double charges = double.Parse(splittedRecord[6]);
                    string[] splittedRecordForSeats = splittedRecord[7].Split(';');

                    List<int> seats = new List<int>();
                    for (int x = 0; x < splittedRecordForSeats.Length; x++)
                    {
                        int seat = int.Parse(splittedRecordForSeats[x]);
                        seats.Add(seat);
                    }



                    Customer customer = new Customer(Name, password, role, contact, address, charges, seats, serial);
                    AddCustomerToList(customer);

                }

                f.Close();
                return true;
            }
            return false;

        }
        public static double GetTotalPrice()
        {
            double charges;
            foreach (var x in customersList)
            {
                charges = x.GetCharges();
                return charges;
            }
            return 0;

        }

    }
}
