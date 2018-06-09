using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_Samochodow.Models
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation()
        {
            if (this.Username.Equals("username") && this.Password.Equals("password"))
                return true;
            else
                return false;
        }
    }
}
