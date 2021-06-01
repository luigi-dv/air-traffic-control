using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsLib
{
    class Airlane
    {
        private string airlaneID, name, email, website, country, direction;
        private int phonePrefix, phone;

        //Getters and Setters
        public string AirlaneID
        {
            get { return airlaneID; }
            set { airlaneID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Website
        {
            get { return website; }
            set { website = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        public int PhonePrefix
        {
            get { return phonePrefix; }
            set { phonePrefix = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
