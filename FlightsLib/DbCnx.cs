using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
namespace FlightsLib
{
    public class DbCnx
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
            DataTable airlines = new DataTable();
            string sql = "SELECT rowid, * FROM airlines";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(airlines);
            return airlines;
        }

        public int GetAirlane(int rowid)
        {
            string query = "SELECT COUNT(*) FROM airlines WHERE rowid=" + rowid+ "";
            SQLiteCommand comm = new SQLiteCommand(query, this.cnx);
            int RowCount = Convert.ToInt32(comm.ExecuteScalar());
            return RowCount;
        }
        public int GetAirlaneByID(string id)
        {
            string query = "SELECT COUNT(*) FROM airlines WHERE id = '" + id + "'";
            SQLiteCommand comm = new SQLiteCommand(query, this.cnx);
            int RowCount = Convert.ToInt32(comm.ExecuteScalar());
            return RowCount;
        }

        public string[] GetAirlineByName(string name)
        {
            DataTable tableUser = new DataTable();
            string sql = "SELECT email, prefixPhone, phone FROM airlines WHERE name='" + name + "'";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(tableUser);
            string[] company = new string[2];
            foreach (DataRow row in tableUser.Rows)
            {
                company[0] = row["email"].ToString();
                company[1] = "+" + row["prefixPhone"].ToString() + " " + row["phone"].ToString();
              
            }
            return company;
        }

        public void DeleteAirline(int rowid)
        {
            string query = "DELETE FROM airlines WHERE rowid=" + rowid + "";
            SQLiteCommand comm = new SQLiteCommand(query, this.cnx);
            comm.ExecuteNonQuery();
        }

        public void InsertAirline(string id, string name, string country, string prefixPhone, string phone, string email, string direction, string website)
        {
            string query = "INSERT INTO airlines VALUES ('" + id + "','" + name + "','" + country + "','" + prefixPhone + "','" + phone + "','" + email + "','" + direction + "','" + website+"')";
            SQLiteCommand comm = new SQLiteCommand(query, this.cnx);
            comm.ExecuteNonQuery();
        }
        public void UpdateAirline(int rowid,string id, string name, string country, string prefixPhone , string phone, string email, string direction, string website)
        {
            string query = "UPDATE airlines SET id='"+id+"', name='" + name + "', country='" + country + "', prefixPhone=" +prefixPhone+ ",phone="+phone+ ", email='" + email + "', direction='" + direction+ "', website='" + website+ "' WHERE rowid=" + rowid + ""; 
            SQLiteCommand comm = new SQLiteCommand(query, this.cnx);
            comm.ExecuteNonQuery();
        }

        /********************* AUTH SECTION *************************
        ************************************************************************************************/
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
        public int checkID(int userId)
        {
            string query = "SELECT COUNT(*) FROM users WHERE id = '" + userId + "'";
            SQLiteCommand comm = new SQLiteCommand(query, this.cnx);
            int value = comm.ExecuteNonQuery();
            return value;
        }

        public void SetUser(User userToSet)
        {
           
            string query = "INSERT INTO users VALUES('" + userToSet.IdUser+"','"+userToSet.Username+ "','"+userToSet.Email+ "','"+userToSet.Password+"','"+userToSet.ConfirmationCode+ "','"+userToSet.Verified+ "','"+userToSet.Token+"')";
            SQLiteCommand comm = new SQLiteCommand(query, this.cnx);
            comm.ExecuteNonQuery();
        }

        public void SaveUserFlightData(int userID, FlightsList flights)
        {
            for(int i=0; i < flights.Number; i++)
            {
                DateTime today = DateTime.Today;
                string query = "INSERT INTO dataUserFlight VALUES('" + userID + "','" + today + "','" + flights.Flights[i].FlightID + "','" + flights.Flights[i].Company + "','" + flights.Flights[i].PositionX + "','" + flights.Flights[i].PositionY + "','" + flights.Flights[i].OriginX + "','" + flights.Flights[i].OriginY + "','" + flights.Flights[i].DestinationX + "','" + flights.Flights[i].DestinationY + "','" + flights.Flights[i].Velocity + "')";
                SQLiteCommand comm = new SQLiteCommand(query, this.cnx);
                comm.ExecuteNonQuery();
            }

        }
        public DataTable ShowUserDataFlight(int userID)
        {
            string query = "SELECT date,flightID,flightCompany,flightPositionX,flightPositionY,flightOriginX,flightOriginY,flightDestinationX,flightDestinationY,flightVelocity FROM dataUserFlight WHERE id = '" + userID + "'";
            DataTable table = new DataTable();
            SQLiteDataAdapter adp = new SQLiteDataAdapter(query, this.cnx);
            adp.Fill(table);
            return table;
        }
        

        /********************* Email Section *************************
                  **   Getting the email client from our data base for a better security if you wanna add more execute the sqlite command 
                  **   Insert your email client data in the emailClient table
                 ************************************************************************************************/

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
