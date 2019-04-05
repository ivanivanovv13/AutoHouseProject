using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace AutoHouse.View
{
    public partial class Form11 : Form
    {
        Users users;
        List<AutoHouse> AutoHouse = new List<AutoHouse>();

        public Form11(Users users)
        {
            this.users = users;



            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");

            

            try
            {
                using (connection)
                {
                    MySqlCommand sqlcom = new MySqlCommand("select autohouses.id,autohouses.name,autohouses.adress,autohouses.id_owner,autohouses.town from autohouses join users_ah on users_ah.id_ah=autohouses.id where users_ah.id_users = '" + users.Id + "' ;", connection);
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

                        MySqlConnection connectionCarForSell = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");

                        MySqlConnection connectionCarForSell = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=090801");

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


                        MySqlConnection connectionRentaCar = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");

                        MySqlConnection connectionRentaCar = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=090801");

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

        public Form11(Users users, List<AutoHouse> autoHouse)
        {
            this.users = users;
            this.AutoHouse = autoHouse;
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            Form fm = new Form13(users,AutoHouse);
            fm.Show();
            this.Hide();
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            Form fm = new Form15(users, AutoHouse);
            fm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form fm = new Form2(users);
            fm.Show();
            this.Hide();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            Form fm = new Form16(users,AutoHouse);
            fm.Show();
            this.Hide();
        }

        private void btnRemoveAH_Click(object sender, EventArgs e)
        {
            Form fm = new Form17(users,AutoHouse);
            fm.Show();
            this.Hide();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Form fm = new Form14(users, AutoHouse);
            fm.Show();
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;


            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");

            

            connection.Open();
            using (connection)
            {
                MySqlCommand sqlcomCar = new MySqlCommand("select permission.delAH,permission.delUser,permission.viewStatistic,permission.addCars,permission.delCars from permission where permission.id_user='"+users.Id+"';", connection);

                MySqlDataReader reader = sqlcomCar.ExecuteReader();

                if(reader.Read())
                {
                    if(reader["delAH"].ToString()=="N")
                    {
                        btnRemoveAH.Enabled = false;
                    }
                    if(reader["delUser"].ToString()== "N")
                    {
                        btnRemoveUser.Enabled = false;
                    }
                    if (reader["viewStatistic"].ToString() == "N")
                    {
                        btnStatistic.Enabled = false;
                    }
                    if (reader["addCars"].ToString() == "N")
                    {
                        btnAddCar.Enabled = false;
                    }
                    if (reader["delCars"].ToString() == "N")
                    {
                        btnRemoveCar.Enabled = false;
                    }
                }
                reader.Close();
                sqlcomCar.Dispose();
            }


        }
    }
}
