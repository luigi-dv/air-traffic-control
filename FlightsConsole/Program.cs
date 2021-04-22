using System;
using System.Threading;
using FlightsLib;

namespace FlightsConsole
{
    class Program
    {
        //Constantes con los nombres de los ficheros
        private const string fileUserFlights = "vuelos.txt";
        private const string fileUserSector  = "sectores.txt";
        private const string fileNameExport  = "vuelos2.txt";


        //Mensaje con las instrucciones para el usuario
        public static void Welcome()
        {

            Console.Write(
                            "\nMENU PRINCIPAL \n" +
                            "1 - Mostrar posición vuelos\n" +
                            "2 - Mostrar ocupación sector\n" +
                            "3 - Simulación \n" +
                            "4 - Guardar y salir \n");

        }


        private static void Main(string[] args)
        {
           
            FlightsList myFlightList = new FlightsList();
            Sector mySector = new Sector();

            //Project title
            Console.WriteLine("SIMULADOR DE TRAFICO AEREO - GRUPO 6");

            //Condition variable if the files loads
            bool flightLoaded = false;
            bool sectorsLoaded = false;

            //Loading the lists for work w/it 
            int resultFlights = myFlightList.LoadFlightsFile(fileUserFlights);
            int resultSector  = mySector.LoadSectorFile(fileUserSector);

            //Check if Flight File is correctly loaded
            if (resultFlights == -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fichero de vuelos no se ha encontrado.");
                Console.ResetColor();
            }
            else
            {
                if (resultFlights == -2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Fichero de vuelos no tiene un formato válido.");
                    Console.ResetColor();
                }
                else
                {
                    //Shows that the file is correctly readed
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Fichero de vuelos leído correctamente");
                    //File Loaded
                    flightLoaded = true;
                    //Reset the color
                    Console.ResetColor();
                }
            }

            
            //Check if Sectors File is correctly loaded
            if (resultSector == -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fichero de sectores no se ha encontrado.");
                Console.ResetColor();
            }
            else
            {
                if (resultSector == -2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Fichero de sectores no tiene un formato válido.");
                    Console.ResetColor();
                }
                else
                {
                    //Indica que el archivo se ha leido correctamente
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Fichero de sectores leído correctamente");
                    //Variable fichero cargado
                    sectorsLoaded = true;
                    //Limpia la consola para que el usuario pueda continuar con la siguiente instruccion
                    Console.ResetColor();
                }
            }

            //If both have been loaded
            if((flightLoaded == true) && (sectorsLoaded == true))
            {
                //Se muestran las opciones al usuario
                Welcome();
                bool exit = false;

                while (!exit)
                {
                    switch (Console.ReadLine())
                    {
                        //MOSTRAS EMPRESAS POR PANTALLA 
                        case "1":
                            {
                                //Muestra la lista de vuelos 
                                myFlightList.ShowConsoleFlights();
                            }
                            break;
                        case "2":
                            {
                                //Shows the sector's traffic
                                mySector.ShowConsoleTraffic(myFlightList);
                            }
                            break;
                        case "3":
                            {
                                Console.Write("Escribe el tiempo de ciclo:");
                                try
                                {
                                    int inputUserCicle = Convert.ToInt32(Console.ReadLine());
                                    myFlightList.FlightsSimulation(inputUserCicle);
                                }
                                catch (FormatException)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Error de formato en la entrada, volviendo al menú principal");
                                    Console.ResetColor();
                                   
                                }
                            }
                            break;
                        case "4":
                            {
                                myFlightList.SaveList(fileNameExport);
                                exit = true;
                            }
                            break;
                    }
                    Console.WriteLine();
                    Welcome();
                }
            }
            else
            {
                if ((flightLoaded != true) && (sectorsLoaded != true))
                    Console.WriteLine("\nLos ficheros no se han podido leer, el simulador no puede abrirse sin datos.");
                else
                {
                    if ((flightLoaded != true) || (sectorsLoaded != true))
                        Console.WriteLine("\nEl simulador no puede funcionar con alguno de los dos ficheros comprometido.");
                    else
                        Console.WriteLine("\nError inesperado");
                }
                Console.Write("Presione una tecla para cerrar el programa.....");
                Console.ReadKey();
            }
            
        }
    }
}


