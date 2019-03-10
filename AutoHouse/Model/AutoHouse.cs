using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHouse
{
    class AutoHouse
    {
        private  string  name;
        private string   town;
        private List<Car> cars=new List<Car>();
        
        public AutoHouse(string name,string town,List<Car> auto)
        {
            this.name = name;
            this.town = town;
            this.cars = auto;
        }
        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }


        public string Town
        {
            get { return  town; }
            set { town = value; }
        }

        public  string  Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
