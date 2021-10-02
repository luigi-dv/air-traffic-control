using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightsLib
{
    public class SectorsList
    {
        private Sector[] mySectorsVector = new Sector[100];
        public Sector[] Sector
        {
            get { return mySectorsVector; }
            set { mySectorsVector = value; }
        }
        //Se atribuye recoge de vuelos para poder efectuar la busqueda correctamente
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int LoadSectorsFile(string fileUserRecived)
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
                    string[] splits = row.Split('-');

                    //Check para compatibilidad del archivo con otros fichero de texto con split tipo espacio ej: DRAM files o otros ficheros similares 
                    if (splits.Length == 6)
                    {
                        Sector u = new Sector
                        {
                            SectorID = splits[0],
                            Capacity = Convert.ToInt32(splits[1]),
                            PositionX = float.Parse(splits[2]),
                            PositionY = float.Parse(splits[3]),
                            Width = float.Parse(splits[4]),
                            Height = float.Parse(splits[5])
                        };
                        this.Sector[number] = u;
                        result = 0;
                    }
                    row = F.ReadLine();
                    number++;
                }
                F.Close();
                //Retorna la variable result que es -2 por defecto y solo cambia si el fichero tiene los 6 splits
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
    }
}
