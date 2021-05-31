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
        //Se atribuye recoge de vuelos para poder efectuar la busqueda correctamente
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

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
                /*string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Files/");
                string file = path + fileUserRecived;*/
                StreamReader F = new StreamReader(fileUserRecived);

                string row = F.ReadLine();

                int result = -2;
                while (row != null)
                {
                    string[] splits = row.Split(';');

                    //Check para compatibilidad del archivo con otros fichero de texto con split tipo espacio ej: DRAM files o otros ficheros similares 
                    if (splits.Length == 9)
                    {
                        Flight u = new Flight
                        {
                            FlightID = splits[0],
                            Company = splits[1],
                            PositionX = float.Parse(splits[2]),
                            PositionY = float.Parse(splits[3]),
                            OriginX = float.Parse(splits[4]),
                            OriginY = float.Parse(splits[5]),
                            DestinationX = float.Parse(splits[6]),
                            DestinationY = float.Parse(splits[7]),
                            Velocity = float.Parse(splits[8])
                        };
                        this.Flights[number] = u;
                        result = 0;
                    }
                    row = F.ReadLine();
                    number++;
                }
                F.Close();
                //Retorna la variable result que es -2 por defecto y solo cambia si el fichero tiene los 9 splits
                return result;

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
            StreamWriter f = new StreamWriter(fileName);

            for (int i=0 ; i < number; i++)
            {
                Flight Flight = this.Flights[i];

                f.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8}",
                            Flight.FlightID, Flight.Company, Flight.PositionX, Flight.PositionY,
                            Flight.OriginX, Flight.OriginY, Flight.DestinationX, Flight.DestinationY,Flight.Velocity);

                //Salto de linea
                f.WriteLine();

            }
            f.Close();
        }
    }
}

