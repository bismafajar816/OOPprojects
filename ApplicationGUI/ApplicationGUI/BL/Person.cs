using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGUI.BL
{
    class Person
    {
        private string name;
        private string password;
        private string role;
        private string contactNumber;
        private string Address;
        public Person()
        {

        }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Address1 { get => Address; set => Address = value; }

        public Person(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
        public Person(string name, string password, string role, string contactNumber, string Address)
        {
            SetName(name);
            SetPassword(password);
            SetRole(role);
            SetAddress(Address);
            SetContactNumber(contactNumber);

        }
        public void SetContactNumber(string contactNumber)
        {
            if (contactNumber != "")
            {
                this.ContactNumber = contactNumber;
            }
        }
        public void SetAddress(string Address)
        {
            if (Address != "")
            {
                this.Address1 = Address;
            }
        }

        public void SetName(string name)
        {
            if (name != "")
            {
                this.Name = name;
            }
        }
        public void SetPassword(string password)
        {
            if (password != "")
            {
                this.Password = password;
            }
        }
        public void SetRole(string role)
        {
            if (role == "admin" || role == "customer" || role == "driver" || role == "staff")
            {
                this.Role = role;
            }
        }

        public string GetName()
        {
            return Name;
        }
        public string GetPassword()
        {
            return Password;
        }
        public string GetRole()
        {
            return Role;
        }
        public string GetContact()
        {
            return ContactNumber;
        }
        public string GetAddress()
        {
            return Address1;
        }

        public string GetCSV()
        {
            string line;
            line = GetName() + "," + GetPassword() + "," + GetRole() + "," + GetContact() + "," + GetAddress();
            return line;

        }
    }
}
