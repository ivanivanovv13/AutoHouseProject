using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHouse
{
    public class AutoHouse
    {
        private int id;
        private  string  name;
        private string adres;
        private int idOwner;
        private string   town;
        private List<Car> carsForSell = new List<Car>();
        private List<Car> rentaCars = new List<Car>();


        public AutoHouse(int id, string name,string adres, int idOwner,string town,List<Car> carsForSell, List<Car> rentaCars)
        {
            this.Id = id;
            this.Name = name;
            this.Adres=adres;
            this.IdOwner = idOwner;
            this.Town = town;
            this.CarsForSell = carsForSell;
            this.RentaCars = rentaCars;
        }
        
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Adres
        {
            get { return this.adres; }
            set { this.adres = value; }
        }

        public int IdOwner
        {
            get { return this.idOwner; }
            set { this.idOwner = value; }
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

        public List<Car> CarsForSell
        {
            get { return this.carsForSell; }
            set { this.carsForSell = value; }
        }
        public List<Car> RentaCars
        {
            get { return this.rentaCars; }
            set { this.rentaCars = value; }
        }
    }
}
