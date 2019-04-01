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

namespace AutoHouse.View
{
    public partial class Form7 : Form
    {
        Users users;
        List<AutoHouse> AutoHouse = new List<AutoHouse>();

        List<StatisticSell>[] statisticSells;

        List<StatisticRent>[] statisticRents;

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        public Form7(Users user,List<AutoHouse> AutoHouse)
        {
            this.AutoHouse = AutoHouse;

            statisticSells = new List<StatisticSell>[AutoHouse.Count];
            statisticRents = new List<StatisticRent>[AutoHouse.Count];
            this.users = user;
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            if (this.AutoHouse.Count() == 1)
            {
                comboBoxAutoHouse.Visible = false;
            }
            else
            {
                comboBoxAutoHouse.Show();
                for (int i = 0; i < AutoHouse.Count(); i++)
                {
                    
                    comboBoxAutoHouse.Items.Add(this.AutoHouse[i].Name + " " + this.AutoHouse[i].Adres + " " + this.AutoHouse[i].Town);
                }
            }


            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=1234");
            try
            {
                using (connection)
                {
                    connection.Open();
                    for (int i = 0; i < AutoHouse.Count; i++)
                    {
                        statisticSells[i] = new List<StatisticSell>();
                        MySqlCommand sqlcom = new MySqlCommand("select users.user,autohouses.name ,cars.id,cars.model,cars.brand,cars.color,cars.year,cars.probeg,cars.image,statistic_sell.moneyForSell,statistic_sell.soldDate from statistic_sell join users on users.id=statistic_sell.id_user join cars on statistic_sell.id_car=cars.id join autohouses on autohouses.id=statistic_sell.id_AH where autohouses.id ='" + AutoHouse[i].Id + "';", connection);
                        
                        MySqlDataReader reader = sqlcom.ExecuteReader();

                        while (reader.Read())
                        {
                            string username = reader["user"].ToString();
                            int idCar = int.Parse(reader["id"].ToString());
                            string brand = reader["brand"].ToString();
                            string model = reader["model"].ToString();
                            string color = reader["color"].ToString();
                            double price = double.Parse(reader["moneyForSell"].ToString());
                            int year = int.Parse(reader["year"].ToString());
                            int probeg = int.Parse(reader["probeg"].ToString());
                            byte[] image = checked((byte[])reader["image"]);
                            Image images;
                            MemoryStream stream = new MemoryStream(image);
                            stream.Seek(0, SeekOrigin.Begin);
                            images = Image.FromStream(stream);
                            Car tempCar = new Car(idCar, brand, model, color, price, year, probeg, images);
                            decimal MoneyForSell = decimal.Parse(reader["moneyForSell"].ToString());
                            DateTime SoldDate = DateTime.Parse(reader["soldDate"].ToString());
                            string autoHousesName = reader["name"].ToString();

                            
                            statisticSells[i].Add(new StatisticSell(username, tempCar, autoHousesName, MoneyForSell, SoldDate));
                            
                        }
                        reader.Close();
                        sqlcom.Dispose();
                    }                    
                }

                using (connection)
                {
                    connection.Open();
                    for (int i = 0; i < AutoHouse.Count; i++)
                    {
                        statisticRents[i] = new List<StatisticRent>();
                        MySqlCommand sqlcom = new MySqlCommand("select users.user,autohouses.name,cars.id,cars.model,cars.brand,cars.color,cars.year,cars.probeg,cars.image,statistic_rent.time_take,statistic_rent.time_return,statistic_rent.moneyForRent from statistic_rent join cars on cars.id=statistic_rent.id_cars join users on users.id=statistic_rent.id_user join autohouses on autohouses.id = statistic_rent.id_AH where autohouses.id = '" + AutoHouse[i].Id +"'; ", connection);

                        MySqlDataReader reader = sqlcom.ExecuteReader();

                        while (reader.Read())
                        {
                            string username = reader["user"].ToString();
                            int idCar = int.Parse(reader["id"].ToString());
                            string brand = reader["brand"].ToString();
                            string model = reader["model"].ToString();
                            string color = reader["color"].ToString();
                            double price = double.Parse(reader["moneyForRent"].ToString());
                            int year = int.Parse(reader["year"].ToString());
                            int probeg = int.Parse(reader["probeg"].ToString());
                            byte[] image = checked((byte[])reader["image"]);
                            Image images;
                            MemoryStream stream = new MemoryStream(image);
                            stream.Seek(0, SeekOrigin.Begin);
                            images = Image.FromStream(stream);
                            Car tempCar = new Car(idCar, brand, model, color, price, year, probeg, images);
                            decimal MoneyRent = decimal.Parse(reader["moneyForRent"].ToString());
                            DateTime timeTake = DateTime.Parse(reader["time_take"].ToString());
                            DateTime timeReturn = DateTime.Parse(reader["time_return"].ToString());
                            string autoHousesName = reader["name"].ToString();

                            
                            statisticRents[i].Add(new StatisticRent(username, tempCar, autoHousesName, MoneyRent,timeTake,timeReturn));

                        }
                        reader.Close();
                        sqlcom.Dispose();
                    }
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void btnPrintStatistic_Click(object sender, EventArgs e)
        {
            listBoxStatistic.Items.Clear();
            if (radioBtnSellCarsStatistic.Checked == true || radioBtnVsichkiStatistic.Checked == true)
            {
                if (AutoHouse.Count > 1)
                {
                    int index = comboBoxAutoHouse.SelectedIndex;
                    try
                    {
                        for (int i = 0; i < statisticSells[index].Count; i++)
                        {
                            listBoxStatistic.Items.Add(this.statisticSells[index][i].User + " " + this.statisticSells[index][i].AH + " " + this.statisticSells[index][i].Car.Brand + " " + this.statisticSells[index][i].Car.Model + " " + this.statisticSells[index][i].Car.Color + " " + this.statisticSells[index][i].Car.Probeg + " " + this.statisticSells[index][i].Car.Year + " " + this.statisticSells[index][i].SellPrice + " " + this.statisticSells[index][i].SoldTime);
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
                else
                {
                    try
                    {
                        for (int i = 0; i < statisticSells[0].Count; i++)
                        {
                            listBoxStatistic.Items.Add(this.statisticSells[0][i].User + " " + this.statisticSells[0][i].AH + " " + this.statisticSells[0][i].Car.Brand + " " + this.statisticSells[0][i].Car.Model + " " + this.statisticSells[0][i].Car.Color + " " + this.statisticSells[0][i].Car.Probeg + " " + this.statisticSells[0][i].Car.Year + " " + this.statisticSells[0][i].SellPrice + " " + this.statisticSells[0][i].SoldTime);
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
            }

            if (radioBtnRentaCarStatistic.Checked == true || radioBtnVsichkiStatistic.Checked == true)
            {

                if (AutoHouse.Count > 1)
                {
                    int index = comboBoxAutoHouse.SelectedIndex;
                    try
                    {
                        for (int i = 0; i < statisticRents[index].Count; i++)
                        {
                            listBoxStatistic.Items.Add(this.statisticRents[index][i].User + " " + this.statisticRents[index][i].AH + " " + this.statisticRents[index][i].Car.Brand + " " + this.statisticRents[index][i].Car.Model + " " + this.statisticRents[index][i].Car.Color + " " + this.statisticRents[index][i].Car.Probeg + " " + this.statisticRents[index][i].Car.Year + " " + this.statisticRents[index][i].MoneyForRent + " " + this.statisticRents[index][i].TimeTake.ToShortDateString() + " " + this.statisticRents[index][i].TimeReturn.ToShortDateString());
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
                else
                {
                    try
                    {
                        for (int i = 0; i < statisticSells[0].Count; i++)
                        {
                            listBoxStatistic.Items.Add(this.statisticRents[0][i].User + " " + this.statisticRents[0][i].AH + " " + this.statisticRents[0][i].Car.Brand + " " + this.statisticRents[0][i].Car.Model + " " + this.statisticRents[0][i].Car.Color + " " + this.statisticRents[0][i].Car.Probeg + " " + this.statisticRents[0][i].Car.Year + " " + this.statisticRents[0][i].MoneyForRent + " " + this.statisticRents[0][i].TimeTake.ToShortDateString() + " " + this.statisticRents[0][i].TimeReturn.ToShortDateString());
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form fm = new Form6(users,AutoHouse);
            fm.Show();
            this.Hide();
        }
    }
}
