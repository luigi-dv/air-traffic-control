using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace FlightsLib
{
    public class Flight
    {
        public string flightID, company;
        public double positionX, positionY, originX, originY, destinationX, destinationY;
        public double velocity;

        //Muestra un vuelo determinado que recibe como parametro
        public void ShowConsoleFlight()
        {
                
                Console.WriteLine(
                                "{0} " +
                                "X={1} Y={2}",
                                 this.flightID,
                                 this.positionX,
                                 this.positionY
                                 );
        }

        //Simula cada vuelo con el tiempo que recibe por parametro
        //Informa al usuario cuando un avion ya llego a su destino.
        public void Simulator(int inputUserCicle)
        {
 
            double distance;
            double hipotenusa;
            double cos;
            double sin;

            if((this.positionX < this.destinationX) || (this.positionY < this.destinationY))
            {
                distance = inputUserCicle * this.velocity;


                hipotenusa = Math.Sqrt(
                                        ((this.destinationX - this.positionX) * (this.destinationX - this.positionX)) +
                                        ((this.destinationY - this.positionY) * (this.destinationY - this.positionY))
                                        );

                cos = ((this.destinationX - this.positionX) / hipotenusa);
                sin = ((this.destinationY - this.positionY) / hipotenusa);


                this.positionX = Math.Round((this.positionX + distance * cos), MidpointRounding.ToEven);



                this.positionY = Math.Round((this.positionY + distance * sin), MidpointRounding.ToEven);

                ShowConsoleFlight();
            }
            else
            {
                    Console.WriteLine("El vuelo {0} ha llegado a su destino X={1} Y={2}", this.flightID, this.destinationX, this.destinationY);
            }
           
        }
    }
}
