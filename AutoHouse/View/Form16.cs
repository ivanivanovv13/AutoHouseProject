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
    public partial class Form16 : Form
    {
        List<Users> users = new List<Users>();
        Users user;
        List<AutoHouse> autoHouses = new List<AutoHouse>();

        public Form16(Users users, List<AutoHouse> autoHouses)
        {
            this.autoHouses = autoHouses;
            this.user = users;
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");
            try
            { 
                connection.Open();
                using (connection)
                {
                    MySqlCommand sqlcom = new MySqlCommand("select users.id,users.user,users.pass from users where users.id!='" + user.Id + "' and users.pass !='null';", connection);
                    MySqlDataReader MyReader2 = sqlcom.ExecuteReader();
                    while (MyReader2.Read())
                    {
                        int id = int.Parse(MyReader2["id"].ToString());
                        string user = MyReader2["user"].ToString();
                        string pass = MyReader2["pass"].ToString();
                        Users tempUser = new Users(id, user, pass);
                        users.Add(tempUser);
                    }
                }
                
                connection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
            printUsers();
        }

        private void printUsers()
        {
            for (int i = 0; i < users.Count; i++)
            {
                listBoxUser.Items.Add(users[i].Id + " " + users[i].Username);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form fm = new Form11(user,autoHouses);
            fm.Show();
            this.Hide();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteSelectedUser_Click(object sender, EventArgs e)
        {
            
            try
            {
                int index = listBoxUser.SelectedIndex;
                MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");
                MessageBox.Show(index.ToString());
                MySqlCommand sqlcom = new MySqlCommand("DELETE FROM users_ah WHERE users_ah.id_users='"+users[index].Id +"';", connection);
                MySqlDataReader MyReader2;
                connection.Open();
                MyReader2 = sqlcom.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                connection.Close();
                sqlcom.Dispose();
                MyReader2.Dispose();


                List<int> idAutoHouses = new List<int>();
                using (connection)
                {

                    sqlcom = new MySqlCommand("select autohouses.id from autohouses where autohouses.id_owner='" + users[index].Id + "';", connection);
                    connection.Open();
                    MySqlDataReader reader = sqlcom.ExecuteReader();
                    while (reader.Read())
                    {
                        idAutoHouses.Add(int.Parse(reader["id"].ToString()));
                    }
                }

                for (int i = 0; i < idAutoHouses.Count; i++)
                {
                    sqlcom = new MySqlCommand("DELETE FROM users_ah where users_ah.id_ah='" + idAutoHouses[i]+"';", connection);
                    connection.Open();
                    MyReader2 = sqlcom.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    connection.Close();
                    sqlcom.Dispose();
                    MyReader2.Dispose();
                }
                

                connection.Open();
                sqlcom = new MySqlCommand("update users set users.pass=null where users.id='" + users[index].Id + "';", connection);

                MyReader2 = sqlcom.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                connection.Close();
                users.RemoveAt(index);
                listBoxUser.Items.Clear();
                printUsers();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
    }
}
