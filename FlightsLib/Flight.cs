﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace FlightsLib
{
    public class Flight
    {
        private string flightID, company;
        private double positionX, positionY, originX, originY, destinationX, destinationY;
        private double velocity;

        //Getters and Setters

        public string FlightID
        {
            get{return flightID;}
            set{flightID = value;}
        }
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public double PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }
        public double PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }
        public double OriginX
        {
            get { return originX; }
            set { originX = value; }
        }
        public double OriginY
        {
            get { return originY; }
            set { originY = value; }
        }
        public double DestinationX
        {
            get { return destinationX; }
            set { destinationX = value; }
        }
        public double DestinationY
        {
            get { return destinationY; }
            set { destinationY = value; }
        }
        public double Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

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
        //Copia el vuelo y lo devuelve (evita que al cambiar la copia o el origen se sobreescriba la otra)
        public Flight CopyFlightList()
        {
            Flight fl = new Flight();
            fl.flightID = this.flightID;
            fl.company = this.company;
            fl.destinationX = this.destinationX;
            fl.destinationY = this.destinationY;
            fl.positionX = this.PositionX;
            fl.positionY = this.positionY;
            fl.originX = this.originX;
            fl.OriginY = this.originY;
            fl.velocity = this.velocity;
            return (fl);          
        }

        //Simula cada vuelo con el tiempo que recibe por parametro
        //Informa al usuario cuando un avion ya llego a su destino.
        public int Simulator(int inputUserCicle)
        {
 
            double distance;
            double hipotenusa;
            double cos;
            double sin;

            if((this.positionX < this.destinationX) || (this.positionY < this.destinationY))
            {
                distance = inputUserCicle * (this.velocity / 60);


                hipotenusa = Math.Sqrt(
                                        ( (this.destinationX - this.positionX) * (this.destinationX - this.positionX) ) +
                                        ( (this.destinationY - this.positionY) * (this.destinationY - this.positionY) )
                                        );

                cos = ((this.destinationX - this.positionX) / hipotenusa);
                sin = ((this.destinationY - this.positionY) / hipotenusa);

               
                    double temporalX = Math.Round((this.positionX + (distance * cos)), MidpointRounding.AwayFromZero);
                    double temporalY = Math.Round((this.positionY + (distance * sin)), MidpointRounding.AwayFromZero);

                    if (temporalX > this.destinationX)
                    {
                        this.positionX = this.destinationX;
                    }

                    if (temporalY > this.destinationY)
                    {
                        this.positionY = this.destinationY;
                    }

                else
                {
                    this.positionX = temporalX;
                    this.positionY = temporalY;
                }
               
               
                //this.positionX = Math.Round((this.positionX + ((inputUserCicle * (this.velocity / 60)) * ((this.destinationX - this.positionX) / hipotenusa))), MidpointRounding.ToEven);
                //this.positionY = Math.Round((this.positionY + ((inputUserCicle * (this.velocity / 60)) * ((this.destinationY - this.positionY) / hipotenusa))), MidpointRounding.ToEven);

                return 0;
            }
            else
            {
                return -1;
            }
           
        }
    }
}
