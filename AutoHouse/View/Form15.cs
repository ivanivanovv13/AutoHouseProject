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
    public partial class Form15 : Form
    {
        Users users;
        List<AutoHouse> autoHouses = new List<AutoHouse>();

        public Form15(Users users, List<AutoHouse> autoHouses)
        {
            this.autoHouses = autoHouses;
            this.users = users;
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            if (autoHouses.Count() > 1)
            {
                comboBoxAutoHouse.Show();
                for (int i = 0; i < autoHouses.Count(); i++)
                {
                    comboBoxAutoHouse.Items.Add(this.autoHouses[i].Name + " " + this.autoHouses[i].Adres + " " + this.autoHouses[i].Town);
                }
            }
            else
            {
                comboBoxAutoHouse.Visible = false;
            }
        }

        private void PrintCar()
        {
            listBoxCars.Items.Clear();
            if (radioBtnRentaCars.Checked == true || radioBtnAllCars.Checked == true)
            {
                if (autoHouses.Count > 1)
                {
                    int index = comboBoxAutoHouse.SelectedIndex;
                    for (int i = 0; i < autoHouses[index].RentaCars.Count(); i++)
                    {
                        listBoxCars.Items.Add(autoHouses[index].RentaCars[i].Brand + " " + autoHouses[index].RentaCars[i].Model + " " + autoHouses[index].RentaCars[i].Color + " " + autoHouses[index].RentaCars[i].Probeg + " " + autoHouses[index].RentaCars[i].Price);
                    }
                }
                else
                {
                    int index = 0;
                    for (int i = 0; i < autoHouses[index].RentaCars.Count(); i++)
                    {
                        listBoxCars.Items.Add(autoHouses[index].RentaCars[i].Brand + " " + autoHouses[index].RentaCars[i].Model + " " + autoHouses[index].RentaCars[i].Color + " " + autoHouses[index].RentaCars[i].Probeg + " " + autoHouses[index].RentaCars[i].Price);
                    }
                }

            }
            if (radioBtnSellCars.Checked == true || radioBtnAllCars.Checked == true)
            {
                if (autoHouses.Count > 1)
                {
                    int index = comboBoxAutoHouse.SelectedIndex;
                    for (int i = 0; i < autoHouses[index].CarsForSell.Count(); i++)
                    {
                        listBoxCars.Items.Add(autoHouses[index].CarsForSell[i].Brand + " " + autoHouses[index].CarsForSell[i].Model + " " + autoHouses[index].CarsForSell[i].Color + " " + autoHouses[index].CarsForSell[i].Probeg + " " + autoHouses[index].CarsForSell[i].Price);
                    }
                }
                else
                {
                    int index = 0;
                    for (int i = 0; i < autoHouses[index].CarsForSell.Count(); i++)
                    {
                        listBoxCars.Items.Add(autoHouses[index].CarsForSell[i].Brand + " " + autoHouses[index].CarsForSell[i].Model + " " + autoHouses[index].CarsForSell[i].Color + " " + autoHouses[index].CarsForSell[i].Probeg + " " + autoHouses[index].CarsForSell[i].Price);
                    }
                }
            }
        }

        private void btnPrintCars_Click(object sender, EventArgs e)
        {
            PrintCar();
        }

        private void btnDeleteSelectedCar_Click(object sender, EventArgs e)
        {
            if (radioBtnSellCars.Checked == true || radioBtnAllCars.Checked == true)
            {
                if (listBoxCars.Items.Count > 0)
                {
                    try
                    {
                        int index = listBoxCars.SelectedIndex;
                        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=1234");

                        MySqlCommand sqlcom = new MySqlCommand("DELETE FROM carforsell WHERE carforsell.id_car = '" + autoHouses[comboBoxAutoHouse.SelectedIndex].CarsForSell[index].Id + "' LIMIT 1", connection);
                        MySqlDataReader MyReader2;
                        connection.Open();
                        MyReader2 = sqlcom.ExecuteReader();
                        while (MyReader2.Read())
                        {
                        }
                        connection.Close();
                        autoHouses[comboBoxAutoHouse.SelectedIndex].CarsForSell.RemoveAt(index);
                        PrintCar();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            if (radioBtnRentaCars.Checked == true || radioBtnAllCars.Checked == true)
            {
                if (listBoxCars.Items.Count > 0)
                {
                    try
                    {
                        int index = listBoxCars.SelectedIndex;
                        if (index < 0)
                            index = 0;
                        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=1234");
                        MySqlCommand sqlcom = new MySqlCommand("DELETE FROM rent_car WHERE rent_car.id_cars = '" + autoHouses[comboBoxAutoHouse.SelectedIndex].RentaCars[index].Id + "' LIMIT 1", connection);
                        MySqlDataReader MyReader2;
                        connection.Open();
                        MyReader2 = sqlcom.ExecuteReader();
                        while (MyReader2.Read())
                        {
                        }
                        connection.Close();
                        autoHouses[comboBoxAutoHouse.SelectedIndex].RentaCars.RemoveAt(index);
                        PrintCar();
                    }
                    catch (Exception)
                    {


                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form fm = new Form11(users, autoHouses);
            fm.Show();
            this.Hide();
        }

        private void comboBoxAutoHouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
