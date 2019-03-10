using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AutoHouse
{
    class Car
    {
        private string brand;
        private string  model;
        private string color;
        private double price;
        private Image pic;

        public Car(string brand,string model,string color,double price,Image pic)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.price = price;
            this.pic = pic;
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
