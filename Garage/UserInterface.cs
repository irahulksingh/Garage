using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage.Subclasses;

namespace Garage
{
    public class UserInterface : Vehicles
    {
        public void mainmenu()
        {
            Car interfaceCar = new Car("Ayman", 111, "MAN", 222);
            //Garage<Car> garage = new ();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("*************************************************\n              GARAPP \n*************************************************");
                Console.WriteLine("1. CREATE A GARAGE.");
                Console.WriteLine("2. PARK OR UNPARK VEHICLES.");
                Console.WriteLine("3. SHOW ALL VEHICLES");
                Console.WriteLine("0. EXIT.");
                string sControl = Console.ReadLine();
                int iControl;
                if (int.TryParse(sControl, out iControl))
                {
                    switch (iControl)
                    {
                        case 1: CreateGarage(); break;
                        case 2: ParkOrUnpark(); break;
                        case 3: Allvehicles(); break;
                        case 0: return;
                        default: Console.WriteLine("*****PLEASE ENTER A VALUE FROM THE ABLOVE LIST *****"); Console.ReadLine(); break;
                    }
                }
            }
        }

        /// <summary>
        /// FUNCTION/METHOD TO CREATE A GARAGE NAME AND SIZE 
        /// </summary>
        public void CreateGarage()
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();

                //while (true)
                // {

                Console.WriteLine("**************************\n CREATE GARAGE\n************************");
                Console.WriteLine("ENTER THE NUMBER OF YOUR GARAGES CAPACITY:\n");
                string sMaxCap = Console.ReadLine();
                int MaxCapDesired;

                if (int.TryParse(sMaxCap, out MaxCapDesired))
                {
                    if (MaxCapDesired <= 0)
                    {
                        Console.WriteLine("\nINVALID INPUT!!\nYOU SHOULD ENTER NUMBERS TO CAPACITY OF YOUR GARAGE\n" +
                            "PRESS ENTER TO CONTINUE.");
                        Console.ReadLine();
                        break;
                    }
                    
                }
                else if (!int.TryParse(sMaxCap, out MaxCapDesired))
                {
                    Console.WriteLine("YOU SHOULD PUT NUMBERS. PRESS ENTER TO CONTINUE");
                    Console.ReadLine();
                    //return;
                    break;//
                }
                else
                {
                    Console.WriteLine("ELSE");
                }
                
                new Garage<Vehicles>(MaxCapDesired);
                Console.WriteLine("\nPRESS 0 TO EXIT TO MAIN MENU");
                Console.WriteLine("PRESS 1 TO RECREATE YOUR GARAGE SIZE");
                string inputForSeitch = Console.ReadLine();
                switch (inputForSeitch)
                {
                    case "1":
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// THIS IS TO ADD OR REMOVE THINGS
        /// </summary>
        public void ParkOrUnpark()

        {
            Console.Clear();

            while (true)
            {
                Console.Clear();//
                Console.WriteLine("USE + TO   ADD  A VIHICLE\n" +
                                  "USE - TO REMOVE A VIHICLE\n" +
                                  "USE 0 TO EXIT TO MAIN MENU\n"/*+
                                  "USE 9 TO CLEAN THE WINDOW"*/);
                string switchinput01 = Console.ReadLine();
                Console.Clear();//
                switch (switchinput01)
                {
                    case "+":
                        Console.WriteLine("TYPE 1 TO ADD CAR\n" +
                                      "TYPE 2 TO ADD BUS\n" +
                                      "TYPE 3 TO ADD MOTORCYCLE\n" +
                                      "TYPE 4 TO ADD BOAT\n" +
                                      "TYPE 5 TO ADD AIRPLANE\n" +
                                      "TYPE 0 TO EXIT TO MAIN MENU\n" /* +
                                     "TYPE 9 TO CLEAN THE WINDOW"*/);
                        string input = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("YOU CHOSE {0}\n ", input);
                        switch (input)
                        {

                            case "1":
                                Console.WriteLine("YOU ARE WORKING WITH 1 CAR\n");

                                Car newcar = new Car();
                                Console.WriteLine("WHAT IS THE NAME OF YOUR CAR?");// i typed the same message but in big leters
                                var myCarname = Console.ReadLine();
                                newcar.Name = myCarname;
                                Console.WriteLine("WHAT IS THE FUEL TYPE FOR YOUR CAR?");// i typed the same message but in big leters
                                var myCarFuel = Console.ReadLine();
                                newcar.FuelType = myCarFuel;

                                newcar.NoOfEngines = 2;
                                newcar.NoOfSeats = 2;

                                Garage<Car> garagecar = new Garage<Car>(2);
                                garagecar.addtoList(newcar);

                                Console.WriteLine("\nSUCSESS!!! PRESS ENTER TO CONTINUE");
                                Console.ReadLine();

                                break;
                            case "2": Console.WriteLine("YOU ARE WORKING WITH 2 BUS\n"); break;
                            case "3": Console.WriteLine("YOU ARE WORKING WITH 3 MOTORCYCLE\n"); break;
                            case "4": Console.WriteLine("YOU ARE WORKING WITH 4 BOAT\n"); break;
                            case "5": Console.WriteLine("YOU ARE WORKING WITH 5 AIRPLANE\n"); break;
                            case "0": Console.WriteLine("RETURN ONE STEP BACK\n"); return;
                            //case "9": Console.WriteLine("CLEAN THE WINDOW"); Console.Clear(); break;
                            default: Console.WriteLine("INVALID INPUT! ENTER SOMETHING FROM OPTIONS\n"); break;


                        }
                        break;

                    case "-":
                        Console.WriteLine("!!!YOU ARE REMOVEING SOMETHING NOW!!!\n");
                        break;
                    case "0":
                        return;
                    /*case "9":
                        Console.Clear();
                        break;*/
                    default:
                        Console.WriteLine("INVALID INPUT!!! PRESS ENTER TO CONTINUE.");
                        Console.ReadLine();
                        break;
                }

            }

        }


        /// <summary>
        /// WHAT IS THE POINT OF THIS METHOD???
        /// </summary>
        public void Allvehicles()
        {
            Console.WriteLine("YOUR GARAGE NAME IS SIZE IS ");

        }

        //Motorcycle moto = new Motorcycle("harley", 2, "petrol", 1);
        //Garage<Vehicles> Addnew = new Garage<Vehicles>(moto);
        //Addnew.AddVehicle(moto);
        //foreach (var i in Addnew)
        //{
        //    Console.WriteLine(i.GarageInfo());
        //}
        //Console.WriteLine("");
        //Console.ReadLine();
    }




}
