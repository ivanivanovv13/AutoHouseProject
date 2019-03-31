using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHouse
{
    class StatisticRent
    {
        public StatisticRent(string user, Car car, string AH, decimal price, DateTime timeTake, DateTime timeReturn)
        {
            this.User = user;
            this.Car = car;
            this.AH = AH;
            this.MoneyForRent = price;
            this.TimeTake = timeTake;
            this.TimeReturn = timeReturn;
        }

        private string user;
        private Car car;
        private string ahName;
        private decimal moneyForRent;
        private DateTime timeTake;
        private DateTime timeReturn;

        public string User
        {
            get { return this.user; }
            set { this.user = value; }
        }

        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        public string AH
        {
            get { return this.ahName; }
            set { this.ahName = value; }
        }

        public decimal MoneyForRent
        {
            get { return this.moneyForRent; }
            set { this.moneyForRent = value; }
        }

        public DateTime TimeTake
        {
            get { return this.timeTake; }
            set { this.timeTake = value; }
        }

        public DateTime TimeReturn
        {
            get { return this.timeReturn; }
            set { this.timeReturn = value; }
        }
    }
}
