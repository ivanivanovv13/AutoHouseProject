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
    public partial class Form12 : Form
    {
        Users users;
        AutoHouse autoHouse;
        Car car;

        string timeTake;
        string timeReturn;

        List<AutoHouse> autoHouses = new List<AutoHouse>();
        List<Image> images = new List<Image>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        int curentAH;
        int startCar;
        int startAH;
        int days;


        public Form12(Users users, AutoHouse autoHouse, Car car, List<AutoHouse> autoHouses, int curentAH, int startCar, int startAH,string timeTake,string timeReturn,int days)
        {
            this.curentAH = curentAH;
            this.startAH = startAH;
            this.startCar = startCar;
            this.timeTake = timeTake;
            this.timeReturn = timeReturn;
            this.days = days;


            this.users = users;
            this.autoHouse = autoHouse;
            this.car = car;
            this.autoHouses = autoHouses;
            images.Add(car.Pic);
            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=1234");
            using (connection)
            {
                connection.Open();
                MySqlCommand sqlcom = new MySqlCommand("select images.image from images where images.idCar='" + car.Id + "'; ", connection);

                MySqlDataReader reader = sqlcom.ExecuteReader();
                while (reader.Read())
                {
                    byte[] image = checked((byte[])reader["image"]);
                    MemoryStream stream = new MemoryStream(image);
                    stream.Seek(0, SeekOrigin.Begin);
                    images.Add(Image.FromStream(stream));
                }
            }

            InitializeComponent();
        }

        

        private void Form12_Load(object sender, EventArgs e)
        {
            pictureBoxes.Add(pictureBoxImage1);
            pictureBoxes.Add(pictureBoxImage2);
            pictureBoxes.Add(pictureBoxImage3);
            pictureBoxes.Add(pictureBoxImage4);
            pictureBoxes.Add(pictureBoxImage5);
            pictureBoxes.Add(pictureBoxImage6);
            pictureBoxes.Add(pictureBoxImage7);
            pictureBoxes.Add(pictureBoxImage8);

            pictureBoxImage1.Image = images[0];
            pictureBoxZoomImage.Image = images[0];

            for (int i = 1; i < images.Count; i++)
            {
                pictureBoxes[i].Image = images[i];
            }

            lblBrand.Text = "Brand: " + car.Brand;
            lblColor.Text = "Color: " + car.Color;
            lblModel.Text = "Model: " + car.Model;
            lblMoney.Text = "Money: " + car.Price;
            lblProbeg.Text = "Probeg: " + car.Probeg;
            lblYear.Text = "Year: " + car.Year;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form fm = new Form5(users, autoHouses);
            fm.Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connectionStatistic = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=1234");
                connectionStatistic.Open();
                using (connectionStatistic)
                {
                    MySqlCommand cmd = new MySqlCommand("insert into statistic_rent(id_user,id_cars,id_AH,time_take,time_return,moneyForRent) values(@idUser,@idCar,@idAH,@timeTake,@timeReturn,@MoneyForSell);", connectionStatistic);

                    cmd.Parameters.AddWithValue("@idUser", users.Id);
                    cmd.Parameters.AddWithValue("@idCar", car.Id);
                    cmd.Parameters.AddWithValue("@idAH", autoHouse.Id);
                    cmd.Parameters.AddWithValue("@timeTake", timeTake);
                    cmd.Parameters.AddWithValue("@timeReturn", timeReturn);
                    cmd.Parameters.AddWithValue("@MoneyForSell", car.Price*days);


                    cmd.ExecuteNonQuery();
                }

                connectionStatistic.Open();
                using (connectionStatistic)
                {
                    MySqlCommand cmd = new MySqlCommand("insert into grafik(id_user,id_cars,time_take,time_return) values (@idUser,@idCar,@timeTake,@timeReturn);", connectionStatistic);

                    cmd.Parameters.AddWithValue("@idUser", users.Id);
                    cmd.Parameters.AddWithValue("@idCar", car.Id);
                    cmd.Parameters.AddWithValue("@timeTake", timeTake);
                    cmd.Parameters.AddWithValue("@timeReturn", timeReturn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

            }

            

            MessageBox.Show("Vie si naehte kola");
            btnRent.Visible = false;
        }

        private void pictureBoxImage1_Click(object sender, EventArgs e)
        {
            pictureBoxZoomImage.Image = pictureBoxImage1.Image;
        }

        private void pictureBoxImage2_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage2.Image != null)
                pictureBoxZoomImage.Image = pictureBoxImage2.Image;
        }

        private void pictureBoxImage3_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage3.Image != null)
                pictureBoxZoomImage.Image = pictureBoxImage3.Image;
        }

        private void pictureBoxImage4_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage4.Image != null)
                pictureBoxZoomImage.Image = pictureBoxImage4.Image;
        }

        private void pictureBoxImage5_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage5.Image != null)
                pictureBoxZoomImage.Image = pictureBoxImage5.Image;
        }

        private void pictureBoxImage6_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage6.Image != null)
                pictureBoxZoomImage.Image = pictureBoxImage6.Image;
        }

        private void pictureBoxImage7_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage7.Image != null)
                pictureBoxZoomImage.Image = pictureBoxImage7.Image;
        }

        private void pictureBoxImage8_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage8.Image != null)
                pictureBoxZoomImage.Image = pictureBoxImage8.Image;
        }
    }
}
