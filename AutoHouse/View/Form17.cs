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
    public partial class Form17 : Form
    {
        Users user;
        List<AutoHouse> autoHouses = new List<AutoHouse>();
        public Form17(Users users, List<AutoHouse> autoHouses)
        {
            this.autoHouses = autoHouses;
            this.user = users;
            InitializeComponent();
        }

        private void printAH()
        {
            listBoxAutoHouses.Items.Clear();
            for (int i = 0; i < autoHouses.Count; i++)
            {
                listBoxAutoHouses.Items.Add(autoHouses[i].Id + " " + autoHouses[i].Name + " " + autoHouses[i].Adres + " " + autoHouses[i].Town);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            printAH();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form fm = new Form11(user, autoHouses);
            fm.Show();
            this.Hide();
        }

        private void btnDeleteSelectedAutoHouse_Click(object sender, EventArgs e)
        {
            int index = listBoxAutoHouses.SelectedIndex;
            try
            {

                MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");

               

                MySqlCommand sqlcom = new MySqlCommand("DELETE FROM users_ah where users_ah.id_ah='" + autoHouses[index].Id + "';", connection);
                MySqlDataReader MyReader2;
                connection.Open();
                MyReader2 = sqlcom.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                connection.Close();
                sqlcom.Dispose();
                MyReader2.Dispose();


                connection.Open();
                sqlcom = new MySqlCommand("update autohouses set autohouses.id_owner=null where autohouses.id='" + autoHouses[index].Id + "';", connection);

                MyReader2 = sqlcom.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                connection.Close();

                autoHouses.RemoveAt(index);

                printAH();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
    }
}
