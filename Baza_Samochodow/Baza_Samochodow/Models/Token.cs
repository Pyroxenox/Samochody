using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_Samochodow.Models
{
    public class Token
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string access_token { get; set; }
        public string Error_description { get; set; }
        /* DateTime Expire_date { get; set; }
        public int Expires_in { get; set; }*/

        public Token() { }
    }
}
