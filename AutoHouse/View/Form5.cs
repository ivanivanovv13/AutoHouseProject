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
    public partial class Form5 : Form
    {
        Users user;
        List<AutoHouse> autoHouses = new List<AutoHouse>();

        List<AutoHouse> autoHousesRenta = new List<AutoHouse>();


        Label[] labelsAH = new Label[5];
        Label[] labelsCars = new Label[5];
        PictureBox[] pictureBoxesCars = new PictureBox[5];
        private int curentAhID;

        int startCar = 0;
        int startAH = 0;

        private void addLabelAndPictureBox()
        {
            labelsAH[0] = lblAH1;
            labelsAH[1] = lblAH2;
            labelsAH[2] = lblAH3;
            labelsAH[3] = lblAH4;
            labelsAH[4] = lblAH5;

            labelsCars[0] = label2;
            labelsCars[1] = label3;
            labelsCars[2] = label5;
            labelsCars[3] = label6;
            labelsCars[4] = label7;

            pictureBoxesCars[0] = pictureBox1;
            pictureBoxesCars[1] = pictureBox2;
            pictureBoxesCars[2] = pictureBox3;
            pictureBoxesCars[3] = pictureBox4;
            pictureBoxesCars[4] = pictureBox5;


        }

        public Form5(Users user, List<AutoHouse> autoHouse)
        {

            this.user = user;
            this.autoHouses = autoHouse;
            this.autoHousesRenta = autoHouse;

  

            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            addLabelAndPictureBox();
            VisibalFalseAll();
            btnNextAH.Visible = false;
            btnPreviousAH.Visible = false;
            btnNextCars.Visible = false;
            btnPreviousCars.Visible = false;


        }

        private void CantRenta()
        {

            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");

           

            try
            {
                
                using (connection)
                {
                    connection.Open();
                    for (int i = 0; i < autoHousesRenta.Count; i++)
                    {
                        MySqlCommand sqlcom = new MySqlCommand("select cars.id ,cars.model,cars.brand,cars.color,cars.year,cars.probeg, cars.image,rent_car.price_day from grafik join cars on grafik.id_cars = cars.id join rent_car on rent_car.id_cars = cars.id join autohouses on autohouses.id = rent_car.id_autoH where( (grafik.time_take<='"+dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and grafik.time_return>='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "') or  (grafik.time_take<='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' and grafik.time_return>='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') or  (grafik.time_take>='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and grafik.time_take<='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') or  (grafik.time_return>='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and grafik.time_return<='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') ) and autohouses.id ='" + autoHousesRenta[i].Id+"' group by cars.id;", connection);

                        MySqlDataReader reader = sqlcom.ExecuteReader();
                        while(reader.Read())
                        {
                            int id = int.Parse(reader["id"].ToString());
                            string model = reader["model"].ToString();
                            string brand= reader["brand"].ToString();
                            string color= reader["color"].ToString();
                            double price = double.Parse(reader["price_day"].ToString());
                            int year= int.Parse(reader["year"].ToString());
                            int probeg= int.Parse(reader["probeg"].ToString());
                            byte[] image = checked((byte[])reader["image"]);
                            Image images;
                            MemoryStream stream = new MemoryStream(image);
                            stream.Seek(0, SeekOrigin.Begin);
                            images = Image.FromStream(stream);
                            for (int j = 0; j < autoHousesRenta[i].RentaCars.Count; j++)
                            {
                                if(id==autoHousesRenta[i].RentaCars[j].Id)
                                {
                                    autoHousesRenta[i].RentaCars.RemoveAt(j);
                                }
                            }
                            
                        }
                        reader.Close();
                        sqlcom.Dispose();
                    }
                    connection.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void displayCars(int start, AutoHouse autoHousesRenta)
        {
            int n = 0;
            if(start==0)
            {
                btnPreviousCars.Visible = false;
            }
            else
            {
                btnPreviousCars.Visible = true;
            }
            if (start+5 < autoHousesRenta.RentaCars.Count())
            {
                btnNextCars.Visible = true;
            }
            
            for (int i = start; i < start + 5; i++)
            {
                if (i < autoHousesRenta.RentaCars.Count)
                {
                    labelsCars[n].Visible = true;
                    pictureBoxesCars[n].Visible = true;
                    labelsCars[n].Text = autoHousesRenta.RentaCars[i].Brand + " " + autoHousesRenta.RentaCars[i].Model + " " + autoHousesRenta.RentaCars[i].Color + " " + autoHousesRenta.RentaCars[i].Year + " " + autoHousesRenta.RentaCars[i].Probeg + " " + autoHousesRenta.RentaCars[i].Price;
                    pictureBoxesCars[n].Image = autoHousesRenta.RentaCars[i].Pic;
                }
                else
                {
                    labelsCars[n].Visible = false;
                    pictureBoxesCars[n].Visible = false;
                }
                n++;
                

            }
        }

        private void displayAH(int start)
        {
            int n = 0;
            for (int i = start; i < start + 5; i++)
            {
                if (i < autoHouses.Count())
                {
                    labelsAH[n].Visible = true;
                    labelsAH[n].Text = i+1 + " " + autoHouses[i].Name + " " + autoHouses[i].Adres + " " + autoHouses[i].Town;
                }
                else
                    labelsAH[n].Visible = false;
                n++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fm = new Form2(user,autoHouses);
            fm.Show();
            this.Hide();
        }

        private void VisibalFalseAll()
        {
            for (int i = 0; i < labelsAH.Count(); i++)
            {
                labelsAH[i].Visible = false;
            }
            for (int i = 0; i < labelsCars.Count(); i++)
            {
                labelsCars[i].Visible = false;
            }
            for (int i = 0; i < pictureBoxesCars.Count(); i++)
            {
                pictureBoxesCars[i].Visible = false;
            }
        }
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            VisibalFalseAll();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            VisibalFalseAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value >= DateTime.UtcNow.Date)
                if (dateTimePicker1.Value < dateTimePicker2.Value)
                {
                    CantRenta();
                    btnPreviousAH.Visible = false;
                    btnPreviousCars.Visible = false;
                    btnNextCars.Visible = false;
                    if (autoHouses.Count() < 5)
                    {
                        btnNextAH.Visible = false;
                    }
                    else
                    {
                        btnNextAH.Visible = true;
                    }

                        displayAH(startAH);
                

                }
            
        }

        private void lblAH1_Click(object sender, EventArgs e)
        {
            displayCars(startCar, autoHousesRenta[startAH]);
        }

        private void btnNextCars_Click(object sender, EventArgs e)
        {
            startCar += 5;
            if (startCar >= autoHousesRenta[curentAhID].RentaCars.Count()-5)
            {
                btnNextCars.Visible = false;
            }
            btnPreviousCars.Visible = true;
            displayCars(startCar, autoHousesRenta[curentAhID]);
        }

        private void btnPreviousCars_Click(object sender, EventArgs e)
        {
            startCar -= 5;
            if (startCar == 0)
            {
                btnPreviousCars.Visible = false;
            }
            btnNextCars.Visible = true;
            displayCars(startCar, autoHousesRenta[curentAhID]);
        }

        private void btnPreviousAH_Click(object sender, EventArgs e)
        {
            startAH -= 5;
            if (startAH == 0)
            {
                btnPreviousAH.Visible = false;
            }
            btnNextAH.Visible = true;
            displayAH(startAH);
        }

        private void btnNextAH_Click(object sender, EventArgs e)
        {
            startAH += 5;
            if (startAH >= autoHouses.Count()-5)
            {
                btnNextAH.Visible = false;
            }
            btnPreviousAH.Visible = true;
            displayAH(startAH);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form fm = new Form12(user,autoHouses[curentAhID],autoHouses[curentAhID].RentaCars[startCar],autoHouses,curentAhID,startCar,startAH, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"),(dateTimePicker2.Value-dateTimePicker1.Value).Days);
            fm.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblAH2_Click(object sender, EventArgs e)
        {
            displayCars(startCar, autoHousesRenta[startAH+1]);
        }

        private void lblAH3_Click(object sender, EventArgs e)
        {
            displayCars(startCar, autoHousesRenta[startAH+2]);
        }

        private void lblAH4_Click(object sender, EventArgs e)
        {
            displayCars(startCar, autoHousesRenta[startAH+3]);
        }

        private void lblAH5_Click(object sender, EventArgs e)
        {
            displayCars(startCar, autoHousesRenta[startAH+4]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form fm = new Form12(user, autoHouses[curentAhID], autoHouses[curentAhID].RentaCars[startCar], autoHouses, curentAhID, startCar, startAH, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), (dateTimePicker2.Value - dateTimePicker1.Value).Days);
            fm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form fm = new Form12(user, autoHouses[curentAhID], autoHouses[curentAhID].RentaCars[startCar+1], autoHouses, curentAhID, startCar, startAH, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), (dateTimePicker2.Value - dateTimePicker1.Value).Days);
            fm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form fm = new Form12(user, autoHouses[curentAhID], autoHouses[curentAhID].RentaCars[startCar + 1], autoHouses, curentAhID, startCar, startAH, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), (dateTimePicker2.Value - dateTimePicker1.Value).Days);
            fm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form fm = new Form12(user, autoHouses[curentAhID], autoHouses[curentAhID].RentaCars[startCar + 2], autoHouses, curentAhID, startCar, startAH, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), (dateTimePicker2.Value - dateTimePicker1.Value).Days);
            fm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form fm = new Form12(user, autoHouses[curentAhID], autoHouses[curentAhID].RentaCars[startCar + 2], autoHouses, curentAhID, startCar, startAH, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), (dateTimePicker2.Value - dateTimePicker1.Value).Days);
            fm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form fm = new Form12(user, autoHouses[curentAhID], autoHouses[curentAhID].RentaCars[startCar + 3], autoHouses, curentAhID, startCar, startAH, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), (dateTimePicker2.Value - dateTimePicker1.Value).Days);
            fm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form fm = new Form12(user, autoHouses[curentAhID], autoHouses[curentAhID].RentaCars[startCar + 3], autoHouses, curentAhID, startCar, startAH, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), (dateTimePicker2.Value - dateTimePicker1.Value).Days);
            fm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form fm = new Form12(user, autoHouses[curentAhID], autoHouses[curentAhID].RentaCars[startCar + 4], autoHouses, curentAhID, startCar, startAH, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), (dateTimePicker2.Value - dateTimePicker1.Value).Days);
            fm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form fm = new Form12(user, autoHouses[curentAhID], autoHouses[curentAhID].RentaCars[startCar + 4], autoHouses, curentAhID, startCar, startAH, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), (dateTimePicker2.Value - dateTimePicker1.Value).Days);
            fm.Show();
            this.Hide();
        }
    }
}
