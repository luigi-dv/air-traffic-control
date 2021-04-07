using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace FlightsLib
{
    public class FlightsList
    {
        public Flight[] Flights = new Flight[10];
      
        //Se atribuye el numero de vuelos para poder efectuar la busqueda correctamente
        public int number;

        //Se muestra en consola una lista con todos los vuelos
        public void ShowConsoleFlights()
        {
            for (int i = 0; i < number; i++)
            {
                Flight Flight = this.Flights[i];

                Flight.ShowConsoleFlight();
            }
        }

        //Se simula cada vuelo de la lista
        public void FlightsSimulation(int inputCicle)
        {
            for (int i = 0; i < number; i++)
            {
                Flight Flight = this.Flights[i];

                Flight.Simulator(inputCicle);
            }
        }

        //Carga el archivo que contiene los datos de los vuelos
        public  int LoadFlightsFile(string fileUserRecived)
        {
            try
            {
                string file = "../../../../Files/" + fileUserRecived;

                
                StreamReader F = new StreamReader(file);

                string row = F.ReadLine();

                while (row!=null)
                {
                    Flight u = new Flight();

                    string[] splits = row.Split(' ');

                    u.flightID = splits[0];
                    u.company = splits[1];
                    u.positionX = float.Parse(splits[2]);
                    u.positionY = float.Parse(splits[3]);
                    u.originX = float.Parse(splits[4]);
                    u.originY = float.Parse(splits[5]);
                    u.destinationX = float.Parse(splits[6]);
                    u.destinationY = float.Parse(splits[7]);
                    u.velocity = float.Parse(splits[8]);

                    this.Flights[number] = u;
                    row = F.ReadLine();

                    number++;
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

        //Guarda la lista en un archivo con el nombre que recibe como parametro 
        public void SaveList(string fileName)
        {
            string file = "../../../../Files/" + fileName;
            StreamWriter f = new StreamWriter(file);

            for (int i=0 ; i < number; i++)
            {
                Flight Flight = this.Flights[i];

                f.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}",
                            Flight.flightID, Flight.company, Flight.positionX, Flight.positionY,
                            Flight.originX, Flight.originY, Flight.destinationX, Flight.destinationY,Flight.velocity);

                //Salto de linea
                f.WriteLine();

            }
            f.Close();
        }
    }
}

