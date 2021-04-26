using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace FlightsLib
{
    public class Sector
    {
        string sectorID;
        int capacity;
        float positionX, positionY, width, height;

        //Se atribuye el numero de sectores para poder efectuar la busqueda correctamente
        const int n = 1;

       
        //Carga el archivo que contiene los datos del sector
        public int LoadSectorFile(string fileUserRecived)
        { 
            try
            {
                /*string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Files/");
                string file = path + fileUserRecived;*/

                StreamReader F = new StreamReader(fileUserRecived);

                string row = F.ReadLine();
                string[] splits = row.Split(' ');

                this.sectorID = splits[0];
                this.capacity = Convert.ToInt32(splits[1]);
                this.positionX = float.Parse(splits[2]);
                this.positionY = float.Parse(splits[3]);
                this.width = float.Parse(splits[4]);
                this.height = float.Parse(splits[5]);
            
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

        //Muestra el trafico aereo que hay en el sector
        public void ShowConsoleTraffic(FlightsList flightsList)
        {

            bool insideX = false; 
            bool insideY = false;

            int insideSectorCount = 0;

            float positionMarginSectorX = 0;
            float positionMarginSectorY = 0;

            positionMarginSectorX = (float)this.positionX + this.width;
            positionMarginSectorY = (float)this.positionY + this.height;
            

            for (int i = 0; i < flightsList.number; i++)
            {
                Flight Flight = flightsList.Flights[i];
                
                if ((this.positionX <= Flight.positionX) && (Flight.positionX <= positionMarginSectorX))
                {
                    insideX = true;
                }

                else
                {
                    if ((this.positionY <= Flight.positionY) && (Flight.positionY <= positionMarginSectorY))
                    {
                        insideY = true;
                    }  
                }

                if(insideX && insideY)
                {
                    insideSectorCount++;
                }
              
               
            }
 
                double insideSectorPercent = (insideSectorCount / (double)this.capacity) * 100;

                Console.WriteLine("Hay {0} vuelos en el sector. La ocupación es del {1}%.", insideSectorCount, insideSectorPercent);
            

        }
    }
}
