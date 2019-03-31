using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AutoHouse
{
    public class Car
    {
        private int id;
        private string brand;
        private string  model;
        private string color;
        private double price;
        private int year;
        private int probeg;
        private Image pic;

        public Car()
        {

        }


        public Car(int id,string brand,string model,string color,double price,int year,int probeg, Image pic)
        {
            this.Id = id;
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Price = price;
            this.Year = year;
            this.Probeg = probeg;
            this.Pic = pic;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public int Probeg
        {
            get { return this.probeg; }
            set { this.probeg = value; }
        }

        public Image Pic
        {
            get { return this.pic; }
            set { this.pic = value; }
        }
        
        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public string  Model
        {
            get { return model; }
            set { model = value; }
        }


        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

    }
}
