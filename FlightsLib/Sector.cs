using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace FlightsLib
{
    public class Sector
    {
        private string sectorID;
        private int capacity;
        private float positionX, positionY, width, height;

        //Getters & Setters 
        public string SectorID
        {
            get{ return sectorID; }
            set{ sectorID = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public float PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }
        public float PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }
        public float Height
        {
            get { return height; }
            set { height = value; }
        }
        

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
                string[] splits = row.Split('-');

                this.SectorID = splits[0];
                this.Capacity = Convert.ToInt32(splits[1]);
                this.PositionX = float.Parse(splits[2]);
                this.PositionY = float.Parse(splits[3]);
                this.Width = float.Parse(splits[4]);
                this.Height = float.Parse(splits[5]);
            
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
        public int GetTraffic(FlightsList flightsList)
        {

            int insideSectorCount = 0;

            float positionMarginSectorX = (float)this.PositionX + this.Width;
            float positionMarginSectorY = (float)this.PositionY + this.Height;

            for (int i = 0; i < flightsList.Number; i++)
            {
                Flight Flight = flightsList.Flights[i];

                if ((this.PositionX <= Flight.PositionX) && (Flight.PositionX <= positionMarginSectorX) && (this.PositionY <= Flight.PositionY) && (Flight.PositionY <= positionMarginSectorY))
                {
                    insideSectorCount++;
                }
            }
            return insideSectorCount;
            

        }
    }
}
