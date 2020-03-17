using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AppTeste
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}
