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

        readonly DbCnx db = new DbCnx();

        public User()
        {
            //Find if another Id match in the table
            bool newId = false;
            int idToSet = 0;
            //While the result of the db query is not 0, the program creates
            //another id and repeat the operation
            db.Start();
            while (newId == false)
            {
                idToSet = SetID();
                //Db check if id exists in table users
                int result = db.checkID(idToSet);
                if (result == 0)
                {
                    newId = true;
                }
            }
            db.End();
            idUser = idToSet ;
        }
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

        public string SetToken()
        {
            var allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var resultToken = new string(
               Enumerable.Repeat(allChar, 8)
               .Select(token => token[random.Next(token.Length)]).ToArray());

            return resultToken.ToString();
        }
        public int SetID()
        {
            Random rnd = new Random();
            int id = rnd.Next(999999);
            return id;
        }
        public void SetUser(User userToSet)
        {
            db.Start();
            db.SetUser(userToSet);
            db.End();
        }
    }
}
