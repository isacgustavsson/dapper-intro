using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Dapper;

using Model;

namespace Data;

public class DbContext
{
    public MySqlConnection GetConnectionString()
    {
        string server = ConfigurationManager.AppSettings.Get("MyServer");
        string database = ConfigurationManager.AppSettings.Get("MyDB");
        string user = ConfigurationManager.AppSettings.Get("MyUser");
        string password = ConfigurationManager.AppSettings.Get("MyPW");

        string connectionString = $"Server={server};Port=17815;Database={database};User ID={user};Password={password}";

        return new MySqlConnection(connectionString);
    }
}