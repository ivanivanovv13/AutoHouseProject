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

namespace AutoHouse
{
    public partial class Form1 : Form
    {
       Controller test = new Controller();




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "LogIn")
            {
                string name = textBox1.Text;
                string pass = textBox2.Text;
                CorrectLogin(test.LogInFill(name,pass));
            }
            else
            {

                bool flag = true;
                MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=1234");
                try
                {
                    connection.Open();
                    using (connection)
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO users (user,pass) VALUES (@user,@pass)", connection);
                        cmd.Parameters.AddWithValue("@user", textBox1.Text);
                        cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception )
                {
                    MessageBox.Show("Imeto veche e izpolzvano");
                    flag = false;
                }
                if(flag)
                {
                    List<int> idAH = new List<int>();

                    connection.Open();
                    using (connection)
                    {
                        MySqlCommand cmd = new MySqlCommand("select autohouses.id	from autohouses where autohouses.id_owner!='NULL' ;", connection);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            idAH.Add(int.Parse(reader["id"].ToString()));
                        }

                    }
                    connection.Close();

                    int idUser = 0;
                    connection.Open();
                    using (connection)
                    {
                        MySqlCommand cmd = new MySqlCommand("select users.id from users where users.user='" + textBox1.Text + "';", connection);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            idUser = int.Parse(reader["id"].ToString());
                        }

                    }
                    connection.Close();


                    connection.Open();
                    using (connection)
                    {
                        MySqlCommand cmd = new MySqlCommand("insert into permission(permission.id_user,permission.addAH,permission.delAH,permission.addUser,permission.delUser,permission.viewStatistic,permission.addCars,permission.delCars,permission.buyCar,permission.rentCar) values(@IdUser,'N','N','N','N','N','N','N','Y','Y');", connection);
                        cmd.Parameters.AddWithValue("@IdUser", idUser);
                        cmd.ExecuteNonQuery();

                    }
                    connection.Close();



                    connection.Open();
                    using (connection)
                    {
                        for (int i = 0; i < idAH.Count; i++)
                        {
                            MySqlCommand cmd = new MySqlCommand("insert into users_ah(id_users,id_ah) values(@IdUser,@IdAH);", connection);
                            cmd.Parameters.AddWithValue("@IdUser", idUser);
                            cmd.Parameters.AddWithValue("@IdAH", idAH[i]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                    MessageBox.Show("You register successfully");

                }



            }
        
        }
        public void CorrectLogin(bool flag)
        {
            if(flag==true)
            {
                Form2 frm = new Form2(test.user);
                frm.Show();
                this.Hide();
            }
            else
            {
                DialogResult erorr;
                erorr = MessageBox.Show("Incorrect username or password", "Erorr", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (erorr == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Clear();
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Clear();
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            if (textBox2.Text== "Password" ) textBox2.PasswordChar = '\0';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "Username";
            textBox2.Text = "Password";
            label1.BackColor = Color.Gray;
            label3.BackColor = Color.White;
            if (pictureBox4.Visible==false) pictureBox4.Visible = true;
            lblReg.Visible = false;
            button1.Text = "LogIn";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            
            textBox1.Text = "Username";
            textBox2.Text = "Password";
            label3.BackColor = Color.Gray;
            label1.BackColor = Color.White;
            if (pictureBox4.Visible) pictureBox4.Visible = false;
            lblReg.Visible = true;
            button1.Text = "Create";
        }
    }
}
