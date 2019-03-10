using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHouse
{
    class Users
    {
        private string  username;
        private string password;
        private List<AutoHouse> aH=new List<AutoHouse>();
        public Users()
        {

        }
        
        public Users(string username,string password,List<AutoHouse> auto)
        {
            this.username = username;
            this.password = password;
            this.aH = auto;

        }
        public List<AutoHouse> AH
        {
            get { return this.aH; }
            set { this.aH = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Username
        {
            get { return username; }
            set { username = value; }
        }

    }
}
