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

        public void Start()
        {
            string dataSource = "Data Source=..\\..\\..\\Database\\projectG6.db";
            cnx = new SQLiteConnection(dataSource);
            cnx.Open();
        }
        public void End()
        {
            cnx.Close();
        }

        public DataTable GetAllAirlines()
        {
            DataTable airlanes = new DataTable();
            string sql = "SELECT * FROM airlanes";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(airlanes);
            return airlanes;
        }
        public DataTable GetAirlane(string id)
        {
            DataTable airlane = new DataTable();
            string sql = "SELECT * FROM airlanes WHERE id=" + id;
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(airlane);
            return airlane;
        }

        //Auth
        public DataTable GetAllUsers()
        {
            DataTable users = new DataTable();
            string sql = "SELECT * FROM users";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(users);
            return users;
        }
        public User GetUser(string usernameEmail)
        {
            DataTable tableUser = new DataTable();
            string sql = "SELECT * FROM users WHERE username='" + usernameEmail + "' OR email='" + usernameEmail+ "'";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(tableUser);
            User user = new User();
            foreach (DataRow row in tableUser.Rows)
            {
                user.IdUser = Convert.ToInt32(row["id"]);
                user.Username = row["username"].ToString();
                user.Email = row["email"].ToString();
                user.Password = row["password"].ToString();
                user.ConfirmationCode = Convert.ToInt32(row["confirmationCode"]);
                user.Verified = Convert.ToBoolean(row["verified"]);
                user.Token = row["token"].ToString();
            }

            return user;
        }
        public void SetUser(User userToSet)
        {
            string query = "INSERT INTO users VALUES('"+userToSet.Username+ "',"+userToSet.Email+ "',"+userToSet.Password+"',"+userToSet.ConfirmationCode+ "',"+userToSet.Verified+ "',"+userToSet.Token+"')";
            SQLiteCommand comm = new SQLiteCommand(query, this.cnx);
            comm.ExecuteNonQuery();
        }

        //Email username to protect psw and username
        public Email GetEmailClient(string username)
        {
            DataTable tableUser = new DataTable();
            string sql = "SELECT * FROM emailClients WHERE username='" + username + "'";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(tableUser);
            Email client = new Email();
            foreach (DataRow row in tableUser.Rows)
            {
                client.Username = row["username"].ToString();
                client.Password = row["psw"].ToString();
            }

            return client;
        }
    }
}
