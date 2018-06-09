using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Baza_Samochodow.Data;
using Baza_Samochodow.iOS.Data;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace Baza_Samochodow.iOS.Data
{
    class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var fileName = "cars.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var librabyPath = Path.Combine(documentPath,"..","Library");
            var path = Path.Combine(librabyPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}