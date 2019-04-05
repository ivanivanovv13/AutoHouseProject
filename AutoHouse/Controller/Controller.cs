using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace AutoHouse
{
    
    class Controller
    {
        int id;
        string namee;
        string passs;
        public Users user;




        public bool LogInFill(string name,string pass)
        {
       
            MySqlConnection connection = new MySqlConnection("datasource=localhost;database=autohouse;username=root;password=ivan1313");
            try
            {
                using (connection)
                {
                    MySqlCommand sqlcom = new MySqlCommand("SELECT id,user,pass from users where user='" + name + "'and pass!='null' ;", connection);
                    connection.Open();
                    MySqlDataReader reader = sqlcom.ExecuteReader();

                    if (reader.Read())
                    {
                        this.id = int.Parse(reader["id"].ToString());
                        this.namee = reader["user"].ToString();
                        this.passs = reader["pass"].ToString();
                    }

                    reader.Close();
                    sqlcom.Dispose();
                }
            }
            catch (Exception)
            {
                return false;
            }
            connection.Close();

            if (pass==this.passs)
            {
                user = new Users(id, namee, passs);
                return true;
            }
            else
            {

                return false;
            }


        }

        public void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
        }

    }
}
