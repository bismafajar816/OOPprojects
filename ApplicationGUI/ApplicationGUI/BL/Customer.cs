using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGUI.BL
{
    class Customer: Person
    {
        private List<int> SeatNumbers = new List<int>();
        private string BusSerial;
        private double charges;
        public Customer()
        {

        }
        public List<int> SeatNumbers1 { get => SeatNumbers; set => SeatNumbers = value; }
        public string BusSerial1 { get => BusSerial; set => BusSerial = value; }
        public double Charges { get => charges; set => charges = value; }

        public Customer(string name, string password, string role, string contactNumber, string Address,double charges, List<int> SeatNumbers, string reservedBus) : base(name, password, role, contactNumber, Address)
        {
            this.SeatNumbers1 = SeatNumbers;
            this.BusSerial1 = reservedBus;
            this.Charges = charges;
        }
        public void AddSeatToList(int seat)
        {
            SeatNumbers1.Add(seat);
        }
        public List<int> GetList()
        {
            List<int> temp = new List<int>();
            temp = SeatNumbers1;
            return temp;
        }
        public double GetCharges(string paymentType)
        {
            if (paymentType == "cash" || paymentType == "Cash")
            {
                Charges = SeatNumbers1.Count() * 1500.0;
                return Charges;
            }
            else if (paymentType == "card" || paymentType == "Card")
            {
                Charges = SeatNumbers1.Count() * 1425.0;
                return Charges;
            }
            return 0;
        }
        public double GetCharges()
        {
            return Charges;
        }
        public bool UpdateSeatNumber(int unChanged, int changed)
        {
            for (int x = 0; x < SeatNumbers1.Count(); x++)
            {
                if (SeatNumbers1[x] == unChanged)
                {
                    SeatNumbers1[x] = changed;
                    return true;
                }
            }
            return false;
        }
        public bool CheckIfReserved(List<int> seatNumber)
        {
            for (int x = 0; x < SeatNumbers1.Count(); x++)
            {
                for (int y = 0; y < seatNumber.Count(); x++)
                {
                    if (SeatNumbers1[x] == seatNumber[y])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public bool CancelSeat(int seatNumber)
        {
            for (int x = 0; x < SeatNumbers1.Count(); x++)
            {
                if (SeatNumbers1[x] == seatNumber)
                {
                    SeatNumbers1.RemoveAt(x);
                    return true;
                }
            }
            return false;
        }
        public double GetRefund(bool flag)
        {
            if (flag == true)
            {
                Charges = Charges - 750;
                return 750;
            }
            return 0;
        }
        public string GetBusSerial()
        {
            return BusSerial1;
        }
        internal Bus Bus
        {
            get => default;
            set
            {
            }
        }
        internal DL.CustomerDL CustomerDL
        {
            get => default;
            set
            {
            }
        }
    }
}
