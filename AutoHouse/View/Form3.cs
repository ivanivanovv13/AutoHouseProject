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

namespace AutoHouse.View
{
    public partial class Form3 : Form
    {
        bool flag=true;
        Users users;
        Form2 form2;

        int idAH;
        List<int> idUser = new List<int>();


        public Form3(Users users,Form2 form2)
        {
            this.form2 = form2;
            this.users = users;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");
            connection.Open();
            using (connection)
            {
                MySqlCommand sqlcomCar = new MySqlCommand("select users.id from users;", connection);

                MySqlDataReader readerCar = sqlcomCar.ExecuteReader();

                while (readerCar.Read())
                {
                    idUser.Add(int.Parse(readerCar["id"].ToString()));
                }
            }
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAdress.Text=="" || txtName.Text=="" || txtTown.Text=="")
            {
                flag = true;
            }
            if (flag)
            {
                MessageBox.Show("Please enter valid information");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");
                connection.Open();
                using (connection)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO autohouses (name,adress,town,id_owner) VALUES (@name,@adress,@town,@id_owner)", connection);

                    cmd.Parameters.AddWithValue("@adress", txtAdress.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@town", txtTown.Text);
                    cmd.Parameters.AddWithValue("@id_owner", users.Id);

                    cmd.ExecuteNonQuery();
                }
                connection.Close();


                connection.Open();
                using (connection)
                {
                    MySqlCommand sqlcomAH = new MySqlCommand("select autohouses.id from autohouses where autohouses.name='" + txtName.Text + "' and autohouses.adress='" + txtAdress.Text + "' and autohouses.town = '" + txtTown.Text + "' and autohouses.id_owner='" + users.Id + "';", connection);

                    MySqlDataReader readerAH = sqlcomAH.ExecuteReader();

                    if (readerAH.Read())
                    {
                        idAH = int.Parse(readerAH["id"].ToString());
                    }
                }
                connection.Close();

                MySqlConnection connectionUserAH = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");
                connectionUserAH.Open();
                using (connectionUserAH)
                {

                    for (int i = 0; i < idUser.Count; i++)
                    {
                        MySqlCommand cmd = new MySqlCommand("insert into users_ah (id_users,id_ah) values(@id_users,@id_ah);", connectionUserAH);
                        cmd.Parameters.AddWithValue("@id_users", idUser[i]);
                        cmd.Parameters.AddWithValue("@id_ah", idAH);
                        cmd.ExecuteNonQuery();
                    }



                }
                connection.Close();
                MessageBox.Show("You successfully create autohouse");
                form2.Reconect();
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                flag = true;
            }
            else flag = false;
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            if (txtAdress.Text == "")
            {
                flag = true;
            }
            else flag = false;
        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {
            if (txtTown.Text == "")
            {
                flag = true;
            }
            else flag = false;
        }
    }
}
