using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Project_0_G6
{
    public class Flight
    {
        public string flightID, company;
        public int positionX, positionY, originX, originY, destinationX, destinationY;
        public double velocity;

        //Child
        public class MyFlights
        {
            public Flight[] Flight = new Flight[10];
        }

        public int LoadFlightsFile(MyFlights list, string fileRecived)
        {
            try
            {
                StreamReader F = new StreamReader(fileRecived);

                //Flights number 
                int n = 3;

                for (int i = 0; i < n; i++)
                {
                    Flight u = new Flight();

                    string linea = F.ReadLine();
                    string[] splits = linea.Split(',');

                    u.flightID = splits[0];
                    u.company = splits[1];
                    u.positionX = Convert.ToInt32(splits[2]);
                    u.positionY = Convert.ToInt32(splits[3]);
                    u.originX = Convert.ToInt32(splits[4]);
                    u.originY = Convert.ToInt32(splits[5]);
                    u.destinationX = Convert.ToInt32(splits[6]);
                    u.destinationY = Convert.ToInt32(splits[7]);
                    u.velocity = Convert.ToDouble(splits[8]);

                    list.Flight[i] = u;
                }

                F.Close();
                return 0;

            }
            catch (FileNotFoundException)
            {
                return -1;
            }

            catch (FormatException)
            {
                return -2;
            }
        }

        public void ShowConsole(MyFlights list, string fileUser) 
        {

                
        }
            
          
        }
        public void Mover(int t) { }
    }
}
