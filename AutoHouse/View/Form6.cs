using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace AutoHouse
{
    public partial class Form6 : Form
    {
        Users users;
        List<AutoHouse> AutoHouse =new List<AutoHouse>();

        public Form6(Users users,List<AutoHouse> autoHouse)
        {
            this.users = users;
            this.AutoHouse = autoHouse;
            InitializeComponent();
        }

        public Form6(Users users)
        {

            this.users = users;



            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=1234");

           

            try
            {
                using (connection)
                {
                    MySqlCommand sqlcom = new MySqlCommand("select autohouses.id,autohouses.name,autohouses.adress,autohouses.id_owner,autohouses.town from autohouses where autohouses.id_owner = '" + users.Id + "' ;", connection);
                    connection.Open();

                    MySqlDataReader reader = sqlcom.ExecuteReader();
                    while (reader.Read())
                    {
                        List<Car> carsForSell = new List<Car>();
                        List<Car> rentaCars = new List<Car>();
                        int id = int.Parse(reader["id"].ToString());
                        string name = reader["name"].ToString();
                        string adres = reader["adress"].ToString();
                        int idOwner = int.Parse(reader["id_owner"].ToString());
                        string town = reader["town"].ToString();

                        MySqlConnection connectionCarForSell = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=1234");

                     

                        connectionCarForSell.Open();
                        using (connectionCarForSell)
                        {
                            MySqlCommand sqlcomCar = new MySqlCommand("select cars.id ,cars.model,cars.brand,cars.color,cars.year,cars.probeg, cars.image , carforsell.price from cars join carforsell on carforsell.id_car = cars.id join autohouses on autohouses.id=carforsell.id_ah where autohouses.id='" + id + "';", connectionCarForSell);

                            MySqlDataReader readerCar = sqlcomCar.ExecuteReader();

                            while (readerCar.Read())
                            {
                                int idCar = int.Parse(readerCar["id"].ToString());
                                string brand = readerCar["brand"].ToString();
                                string model = readerCar["model"].ToString();
                                string color = readerCar["color"].ToString();
                                double price = double.Parse(readerCar["price"].ToString());
                                int year = int.Parse(readerCar["year"].ToString());
                                int probeg = int.Parse(readerCar["probeg"].ToString());
                                byte[] image = checked((byte[])readerCar["image"]);
                                Image images;
                                MemoryStream stream = new MemoryStream(image);
                                stream.Seek(0, SeekOrigin.Begin);
                                images = Image.FromStream(stream);
                                Car tempCar = new Car(idCar, brand, model, color, price, year, probeg, images);
                                carsForSell.Add(tempCar);
                            }
                            readerCar.Close();
                            sqlcomCar.Dispose();
                        }



                        MySqlConnection connectionRentaCar = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=1234");

                      

                        connectionRentaCar.Open();
                        using (connectionRentaCar)
                        {
                            MySqlCommand sqlcomRentaCar = new MySqlCommand("select cars.id ,cars.model,cars.brand,cars.color,cars.year,cars.probeg, cars.image , rent_car.price_day from cars join rent_car on rent_car.id_cars = cars.id join autohouses on autohouses.id=rent_car.id_autoH where autohouses.id='" + id + "';", connectionRentaCar);

                            MySqlDataReader readerRentaCar = sqlcomRentaCar.ExecuteReader();

                            while (readerRentaCar.Read())
                            {
                                int idCar = int.Parse(readerRentaCar["id"].ToString());
                                string brand = readerRentaCar["brand"].ToString();
                                string model = readerRentaCar["model"].ToString();
                                string color = readerRentaCar["color"].ToString();
                                double price = double.Parse(readerRentaCar["price_day"].ToString());
                                int year = int.Parse(readerRentaCar["year"].ToString());
                                int probeg = int.Parse(readerRentaCar["probeg"].ToString());
                                byte[] image = checked((byte[])readerRentaCar["image"]);
                                Image images;
                                MemoryStream stream = new MemoryStream(image);
                                stream.Seek(0, SeekOrigin.Begin);
                                images = Image.FromStream(stream);
                                Car tempCar = new Car(idCar, brand, model, color, price, year, probeg, images);
                                rentaCars.Add(tempCar);
                            }
                            connectionRentaCar.Close();
                            connectionCarForSell.Close();
                            readerRentaCar.Close();

                            sqlcomRentaCar.Dispose();
                        }

                        AutoHouse temp = new AutoHouse(id, name, adres, idOwner, town, carsForSell, rentaCars);
                        AutoHouse.Add(temp);
                    }
                    connection.Close();
                    reader.Close();
                    sqlcom.Dispose();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void Form6_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            
            Form frm = new View.Form7(users,AutoHouse);
            frm.Show();
            this.Hide();
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            Form frm = new View.Form8(users, AutoHouse);
            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form fm = new Form2(users);
            fm.Show();
            this.Hide();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Form frm = new View.Form9(users,AutoHouse);
            frm.Show();
            this.Hide();
        }
    }
}
