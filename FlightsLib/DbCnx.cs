using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
namespace FlightsLib
{
    class DbCnx
    {
        private SQLiteConnection cnx;

        public void Iniciar()
        {
            string dataSource = "..\\..\\..\\database\\projectG6.db";
            cnx = new SQLiteConnection(dataSource);
            cnx.Open();
        }
        public void Cerrar()
        {
            cnx.Close();
        }

        public DataTable GetUsers()
        {
            DataTable users = new DataTable();
            string sql = "SELECT * FROM users";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(users);
            return users;
        }

        public DataTable GetAirlines()
        {
            DataTable airlanes = new DataTable();
            string sql = "SELECT * FROM airlanes";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(airlanes);
            return airlanes;
        }
    }
}
