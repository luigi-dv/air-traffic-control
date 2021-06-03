using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsLib
{

    public class Auth
    {
        readonly DbCnx db = new DbCnx();
        private User userAuth = new User();
        private bool authenticated = false;

        public bool Authenticated
        {
            get { return authenticated; }
            set { authenticated = value; }
        }
       
        public int checkIfExist(string userName, string email)
        {
            db.Start();
            //The user values are defined;
            userAuth = db.GetUser(userName);
            db.End();
            if (userAuth.Email == email)
                //Email is already taken
                return 1;
            else
            {
                if (userAuth.Username == userName)
                    //UserName is already taken
                    return 2;
            }
            return 0;
            
        }
        public int GetID()
        {
            int id = userAuth.IdUser;
            return id;
        }
        public string GetUsername()
        {
            string username = userAuth.Username;
            return username;
        }
        public Auth SetNewUserAuth(User newUser)
        {
            this.userAuth = newUser;
            this.userAuth.Verified = true;
            return this;
        }

        public int CheckLogin(string usernameEmail, string password)
        {
            db.Start();
            //The user values are defined;
            userAuth = db.GetUser(usernameEmail);

            if ((userAuth.Username != usernameEmail && userAuth.Email != usernameEmail))
            {
                //Username do not match
                return 1;
            }
            else
            {
                if (userAuth.Password != password)
                {
                    //Password do not match
                    return 2;
                }
            }

            db.End();
            //User OK
            authenticated = true;
            return 0;
        }

        public void SetUserData(int userID, FlightsList flights) 
        {
            db.Start();
            db.SaveUserFlightData(userID, flights);
            db.End();
        }

        public DataTable ShowUserFlightData(int userID)
        {          
            db.Start();
            DataTable dt = db.ShowUserDataFlight(userID);
            db.End();
            return dt;
        }
       
        
    }
}
