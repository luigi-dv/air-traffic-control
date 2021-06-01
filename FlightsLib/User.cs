using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsLib
{
    public class User
    {
        private int idUser;
        private string username, email, password;
        private int confimationCode;
        private bool verified;
        private string token;

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int ConfirmationCode
        {
            get { return confimationCode; }
            set { confimationCode = value; }
        }
        public bool Verified
        {
            get { return verified; }
            set { verified = value; }
        }
        //Protected only get available 
        
        public string Token
        {
            get { return token; }
            set { token = value;  }
        }
    }
}
