using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGUI.BL
{
    class Driver: Staff
    {
        private string LicenseNumber;

        public string LicenseNumber1 { get => LicenseNumber; set => LicenseNumber = value; }

        internal DL.DriverDL DriverDL
        {
            get => default;
            set
            {
            }
        }

        public Driver(string name, string password, string role, string contactNumber, string Address, string ID, string rank, string dutyTime, string LicenseNumber) : base(name, password, role, contactNumber, Address, ID, rank, dutyTime)
        {
            this.LicenseNumber1 = LicenseNumber;
        }
        public string GetLicenseNumber()
        {
            return LicenseNumber1;
        }
        public void SetLicenseNumber(string LicenseNumber)
        {
            if (LicenseNumber != "")
            {
                this.LicenseNumber1 = LicenseNumber;
            }
        }
        public override string GetCSV()
        {
            string line = GetName() + "," + GetPassword() + "," + GetRole() + "," + GetContact() + "," + GetAddress() + " , " + GetID() + " , " + GetRank() + " , " + GetDutyTime() + " , " + GetLicenseNumber();
            return line;
        }
        public override double GetPay()
        {
            return 30000;
        }

    }
}
