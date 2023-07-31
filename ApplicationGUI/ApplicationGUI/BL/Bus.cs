using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGUI.BL
{
    class Bus
    {
        private string BusNumber;
        private string Timing;
        private string Date;
        private string route;

        public string BusNumber1 { get => BusNumber; set => BusNumber = value; }
        public string Timing1 { get => Timing; set => Timing = value; }
        public string Date1 { get => Date; set => Date = value; }
        public string Route { get => route; set => route = value; }

        internal DL.BusDL BusDL
        {
            get => default;
            set
            {
            }
        }

        public Bus(string BusNumber, string Timing, string Date, string route)
        {
            SetBusNumber(BusNumber);
            SetDate(Date);
            SetRoute(route);
            SetTiming(Timing);
        }
        public void SetBusNumber(string BusNumber)
        {
            if (BusNumber != "")
            {
                this.BusNumber1 = BusNumber;
            }
        }
        public void SetTiming(string Timing)
        {
            if (Timing != "")
            {
                this.Timing1 = Timing;
            }
        }
        public void SetDate(string Date)
        {
            if (Date != "")
            {
                this.Date1 = Date;
            }
        }
        public void SetRoute(string route)
        {
            if (route != "")
            {
                this.Route = route;
            }
        }
        public string GetBusNumber()
        {
            return BusNumber1;
        }
        public string GetDate()
        {
            return Date1;
        }
        public string GetTiming()
        {
            return Timing1;
        }
        public string GetRoute()
        {
            return Route;
        }
        public string GetCSV()
        {
            return GetBusNumber() + " , " + GetDate() + " , " + GetRoute() + " , " + GetTiming();
        }
    }
}
