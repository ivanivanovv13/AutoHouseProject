using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AutoHouse
{
    class Controller
    {
        private List<Users> myList = new List<Users>();
       
        public List<Users> MyList
        {
            get { return myList; }
        }

        public void Fill()
        {
            //ivan
            Image pic=Properties.Resources.bf0fca9f7801e840f24d6d77e7ea8496;//lancer
            Image pic1 = Properties.Resources.images;//opel
            Image pic2 = Properties.Resources.maxresdefault;//niva
            Image pic3 = Properties.Resources._1993_Toyota_Supra_from_The_Fast_and_the_Furious_front_three_quarter_01;//supra
            Image pic4 = Properties.Resources._2018_BMW_X6_01;//x6
            Image pic5 = Properties.Resources._2C3CDXBG7KH550092_1c;//dodge
            Image pic6 = Properties.Resources.download; //488
            Image pic7 = Properties.Resources._86;//ka
            Image pic8 = Properties.Resources.generictwocolumn_f5a_resizeViewPort_noScale;//leon
            List<Car> cars = new List<Car>();
            List<Car> cars2 = new List<Car>();
            List<Car> cars3 = new List<Car>();
            List<AutoHouse> houses = new List<AutoHouse>();
            Car auto = new Car("Toyota", "Supra", "Orange", 20000,pic3);
            Car auto1 = new Car("Dodge", "Charger", "White", 19080,pic5);
            Car auto2 = new Car("Opel", "Costa", "Blue", 500.99,pic1);
            Car avto = new Car("Bmw", "X6", "Black", 30000.20,pic4);
            Car avto1 = new Car("Ford", "Ka", "Yellow", 5500.99,pic7);
            Car avto2 = new Car("Seat", "Leon", "Red", 2500,pic8);
            Car awto = new Car("Ferrari", "488", "Red", 99999999,pic6);
            Car awto1 = new Car("Lada", "Niva", "Green", 2500,pic2);
            Car awto2 = new Car("Mitsubishi", "Lancer", "Pink", 20678,pic);
            cars.Add(auto);
            cars.Add(auto1);
            cars.Add(auto2);
            cars2.Add(avto);
            cars2.Add(avto1);
            cars2.Add(avto2);
            cars3.Add(awto);
            cars3.Add(awto1);
            cars3.Add(awto2);
            AutoHouse u2 = new AutoHouse("BerkAuto","Berkovitsa",cars);
            AutoHouse u3 = new AutoHouse("MontCars", "Montana", cars2);
            AutoHouse u4 = new AutoHouse("Bri4ka", "Sofia", cars3);
            houses.Add(u2);
            houses.Add(u3);
            houses.Add(u4);
            Users u1 = new Users("ivan","1234",houses);
            MyList.Add(u1);
            //alex
         }
       
        public void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
        }

    }
}
