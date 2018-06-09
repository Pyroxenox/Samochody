using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_Samochodow.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
