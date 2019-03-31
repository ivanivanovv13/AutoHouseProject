using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHouse
{
    public class StatisticSell
    {
        public StatisticSell(string user,Car car,string AH,decimal price,DateTime soldTime)
        {
            this.User = user;
            this.Car = car;
            this.AH = AH;
            this.SellPrice = price;
            this.SoldTime = soldTime;
        }

        private string user;
        private Car car;
        private string ahName;
        private decimal sellPrice;
        private DateTime soldTime;   

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

        public decimal SellPrice
        {
            get { return this.sellPrice; }
            set { this.sellPrice = value; }
        }

        public DateTime SoldTime
        {
            get { return this.soldTime; }
            set { this.soldTime = value; }
        }

        
    }
}
