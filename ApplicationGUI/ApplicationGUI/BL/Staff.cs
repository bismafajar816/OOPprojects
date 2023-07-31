using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGUI.BL
{
    class Staff: Person
    {
        private string rank;
        private string dutyTime;
        private string ID;

        public string Rank { get => rank; set => rank = value; }
        public string DutyTime { get => dutyTime; set => dutyTime = value; }
        public string ID1 { get => ID; set => ID = value; }

        internal DL.StaffDL StaffDL
        {
            get => default;
            set
            {
            }
        }

        public Staff(string name, string password, string role, string contactNumber, string Address, string ID, string rank, string dutyTime) : base(name, password, role, contactNumber, Address)
        {
            this.Rank = rank;
            this.DutyTime = dutyTime;
            this.ID1 = ID;
        }
        public string GetRank()
        {
            return Rank;
        }
        public string GetDutyTime()
        {
            return DutyTime;
        }
        public string GetID()
        {
            return ID1;
        }
        public void SetRank(string rank)
        {
            if (rank != "")
            {
                this.Rank = rank;
            }

        }
        public virtual double GetPay()
        {
            return 35000;
        }
        public void SetDutyTime(string dutyTime)
        {
            if (dutyTime == "night" || dutyTime == "day")
            {
                this.DutyTime = dutyTime;
            }
        }
        public void SetID(string ID)
        {
            if (ID != "")
            {
                this.ID1 = ID;
            }
        }

        new public virtual string GetCSV()
        {
            string line = GetName() + "," + GetPassword() + "," + GetRole() + "," + GetContact() + "," + GetAddress() + " , " + GetID() + " , " + GetRank() + " , " + GetDutyTime();
            return line;
        }
    }
}
