using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using MySql.Data.MySqlClient;

namespace AutoHouse.View
{
    public partial class Form14 : Form
    {
        bool flag = true,exep=false;
        int picnumber = 1, idAh, id;
        string ahName;
        Car obj = new Car();
        Users user;
        List<AutoHouse> autoHouse;
        List<Image> pics = new List<Image>();
        public byte[] imageToByte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        Thread myth;
        public void AddCar()
        {

           

            

            connection.Open();
            using (connection)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO cars (model,brand,color,year,probeg,image) VALUES (@model,@brand,@color,@year,@probeg,@image)", connection);

                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@color", txtColor.Text);
                cmd.Parameters.AddWithValue("@year", txtYear.Text);
                cmd.Parameters.AddWithValue("@probeg", txtMileage.Text);

                cmd.Parameters.AddWithValue("@image", imageToByte(pictureBox2.Image));

                cmd.ExecuteNonQuery();
            }

            connection.Close();


            /*pictureBox3.Image.Dispose();
            pictureBox4.Image.Dispose();
            pictureBox5.Image.Dispose();
            pictureBox6.Image.Dispose();
            pictureBox7.Image.Dispose();
            pictureBox8.Image.Dispose();
            pictureBox9.Image.Dispose();*/
        }
        public void Rent()
        {


            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");

            

            connection.Open();
            using (connection)
            {
                string[] words = comboBoxAutoHouses.SelectedItem.ToString().Split(' ');
                ahName = words[0];
                MySqlCommand cmd = new MySqlCommand("INSERT INTO rent_car (id_autoH,id_cars,price_day) VALUES (@id_autoH,@id_cars,@price_day)", connection);
                for (int i = 0; i < autoHouse.Count - 1; i++)
                {
                    if (autoHouse[i].Name == ahName)
                    {
                        idAh = autoHouse[i].Id;
                        Car obj = new Car(GetCarID(), txtBrand.Text, txtModel.Text, txtColor.Text, double.Parse(txtPrice.Text), int.Parse(txtYear.Text), int.Parse(txtMileage.Text), pictureBox2.Image);
                        autoHouse[i].RentaCars.Add(obj);
                    }
                }
                cmd.Parameters.AddWithValue("@id_autoH", idAh);
                cmd.Parameters.AddWithValue("@id_cars", GetCarID());
                cmd.Parameters.AddWithValue("@price_day", txtPrice.Text);
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
        public void Buy()
        {


            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");

            

            connection.Open();
            using (connection)
            {
                string[] words = comboBoxAutoHouses.SelectedItem.ToString().Split(' ');
                ahName = words[0];
                MySqlCommand cmd = new MySqlCommand("INSERT INTO carforsell (id_car,id_ah,price) VALUES (@id_car,@id_ah,@price)", connection);
                for (int i = 0; i < autoHouse.Count - 1; i++)
                {
                    if (autoHouse[i].Name == ahName)
                    {
                        idAh = autoHouse[i].Id;
                        obj = new Car(GetCarID(), txtBrand.Text, txtModel.Text, txtColor.Text, double.Parse(txtPrice.Text), int.Parse(txtYear.Text), int.Parse(txtMileage.Text), pictureBox2.Image);
                        autoHouse[i].CarsForSell.Add(obj);
                    }
                }
                cmd.Parameters.AddWithValue("@id_car", GetCarID());
                cmd.Parameters.AddWithValue("@id_ah", idAh);
                cmd.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void insertPic(Image pic)
        {

            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");

            

            connection.Open();
            using (connection)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO images (idCar,image) VALUES (@id_car,@image)", connection);

                cmd.Parameters.AddWithValue("@id_car", GetCarID());
                cmd.Parameters.AddWithValue("@image", imageToByte(pic));
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
        public int GetCarID()
        {


            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");

            


            using (connection)
            {
                MySqlCommand sqlcom = new MySqlCommand("SELECT id FROM cars ORDER BY id DESC  LIMIT 1;", connection);
                connection.Open();
                MySqlDataReader reader = sqlcom.ExecuteReader();

                if (reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());

                }

                reader.Close();
                sqlcom.Dispose();
            }

            return id;
        }
        public void GetPic()
        {
            if (pictureBox3 != null)
                pics.Add(pictureBox3.Image);
            if (pictureBox4.Image != null)
                pics.Add(pictureBox4.Image);
            if (pictureBox5.Image != null)
                pics.Add(pictureBox5.Image);
            if (pictureBox6.Image != null)
                pics.Add(pictureBox6.Image);
            if (pictureBox7.Image != null)
                pics.Add(pictureBox7.Image);
            if (pictureBox8.Image != null)
                pics.Add(pictureBox8.Image);
            if (pictureBox9.Image != null)
                pics.Add(pictureBox9.Image);


        }

        public Form14(Users user, List<AutoHouse> autoHouses)
        {
            this.user = user;
            this.autoHouse = autoHouses;
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            if (autoHouse.Count > 1)
            {
                comboBoxAutoHouses.Show();
                for (int i = 0; i < autoHouse.Count; i++)
                {
                    comboBoxAutoHouses.Items.Add(autoHouse[i].Name + " " + autoHouse[i].Adres + " " + autoHouse[i].Town);
                }
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text == "" || txtModel.Text == "" || txtColor.Text == "" || txtPrice.Text == "" || txtYear.Text == "" || txtMileage.Text == "")
            {
                flag = true;
            }
            if (flag)
            {
                MessageBox.Show("Please enter all information");
            }
            else
            {
                
                try
                {
                    AddCar();
                    GetPic();
                }
                catch(Exception)
                {
                    MessageBox.Show("Please enter valid information");
                }
                
                foreach (var item in pics)
                {
                    if (item != null)
                        insertPic(item);
                }

                if (rdSell.Checked)
                {
                    try
                    {
                        Buy();
                        exep = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please enter valid information");
                        exep = false;
                    }
                    
                }
                else
                {
                    try
                    {
                        Rent();
                        exep = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please enter valid information");
                        exep = false;
                    }
                   
                }
                if (exep)
                {
                    txtModel.Clear();
                    txtBrand.Clear();
                    txtColor.Clear();
                    txtYear.Clear();
                    txtMileage.Clear();
                    txtPrice.Clear();
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    pictureBox5.Image = null;
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    pictureBox8.Image = null;
                    pictureBox9.Image = null;
                    MessageBox.Show("You successfully inserted car");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            myth = new Thread(new System.Threading.ThreadStart(Call));
            myth.ApartmentState = ApartmentState.STA;
            myth.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form fm = new Form11(user, autoHouse);
            fm.Show();
            this.Hide();
        }

        private void rdRent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRent.Checked)
            {
                lblPrice.Text = "Price a Day:";
                lblPrice.Location = new Point(0, 170);
            }
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            if (txtBrand.Text == "")
            {
                flag = true;
            }
            else flag = false;
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            if (txtModel.Text == "")
            {
                flag = true;
            }
            else flag = false;
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                flag = true;
            }
            else flag = false;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9]"))
            {
                flag = true;
            }
            else flag = false;
        }

        private void txtMileage_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMileage.Text, "[^0-9]"))
            {
                flag = true;
            }
            else flag = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            picnumber = 1;
            myth = new Thread(new System.Threading.ThreadStart(Call));
            myth.ApartmentState = ApartmentState.STA;
            myth.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            picnumber = 2;
            myth = new Thread(new System.Threading.ThreadStart(Call));
            myth.ApartmentState = ApartmentState.STA;
            myth.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            picnumber = 3;
            myth = new Thread(new System.Threading.ThreadStart(Call));
            myth.ApartmentState = ApartmentState.STA;
            myth.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            picnumber = 4;
            myth = new Thread(new System.Threading.ThreadStart(Call));
            myth.ApartmentState = ApartmentState.STA;
            myth.Start();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            picnumber = 5;
            myth = new Thread(new System.Threading.ThreadStart(Call));
            myth.ApartmentState = ApartmentState.STA;
            myth.Start();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            picnumber = 6;
            myth = new Thread(new System.Threading.ThreadStart(Call));
            myth.ApartmentState = ApartmentState.STA;
            myth.Start();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            picnumber = 7;
            myth = new Thread(new System.Threading.ThreadStart(Call));
            myth.ApartmentState = ApartmentState.STA;
            myth.Start();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            picnumber = 8;
            myth = new Thread(new System.Threading.ThreadStart(Call));
            myth.ApartmentState = ApartmentState.STA;
            myth.Start();
        }

        private void rdSell_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSell.Checked)
            {
                lblPrice.Text = "Price :";
                lblPrice.Location = new Point(52, 170);
            }
            
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtYear.Text, "[^0-9]"))
            {
                flag = true;
            }
            else flag = false;
        }

        public void Call()
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // display image in picture box  
                Image img;
                img = new Bitmap(open.FileName);
                switch (picnumber)
                {
                    case 1:
                        pictureBox2.Image = img;
                        break;
                    case 2:
                        pictureBox3.Image = img;
                        break;
                    case 3:
                        pictureBox4.Image = img;
                        break;
                    case 4:
                        pictureBox5.Image = img;
                        break;
                    case 5:
                        pictureBox6.Image = img;
                        break;
                    case 6:
                        pictureBox7.Image = img;
                        break;
                    case 7:
                        pictureBox8.Image = img;
                        break;
                    case 8:
                        pictureBox9.Image = img;
                        break;

                }
                picnumber++;
                if (picnumber > 8) picnumber = 0;
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
