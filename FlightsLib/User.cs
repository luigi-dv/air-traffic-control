using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsLib
{
    public class User
    {
        private string username, email, password;
        private int confimationCode;
        private bool verified;
        //Protected only get available 
        private readonly string token;

        public User()
        {
            token = SetToken();
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
        }


        public string SetToken()
        {
            var allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var resultToken = new string(
               Enumerable.Repeat(allChar, 8)
               .Select(token => token[random.Next(token.Length)]).ToArray());

            return resultToken.ToString();
        }
    }
}
