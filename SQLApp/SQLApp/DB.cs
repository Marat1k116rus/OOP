using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLApp
{
    class DB
    {
        MySqlConnection Connection = new MySqlConnection("Server=localhost;Port=3306;Username=root;Password=root;database=oop");

        public void openConnection()
        {
           
        }

        public void closeConnection()
        {
           
        }

        public MySqlConnection getConnection()
        {
            return Connection;
        }

    }
}
