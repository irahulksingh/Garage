﻿using System;
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
            
            //Garage<Car> garage = new ();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("*************************************************\n              Garage Application \n*************************************************");
                Console.WriteLine("1. Create a Garage.");
                Console.WriteLine("2. Add or Remove vehicles.");
                Console.WriteLine("3. Show all vehicles");
                Console.WriteLine("0. Exit the program.");
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
                        default: Console.WriteLine("*****Please Enter a value from the above list *****"); Console.ReadLine(); break;
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
                Console.WriteLine("YOU ARE CREATING A GARAGE\n");
                Console.WriteLine("What is your garage called :");
                string GarageNameUserInput = Console.ReadLine();
                Console.WriteLine("How big do you want your garage :");
                string sMaxCap = Console.ReadLine();
                int MaxCapDesired;

                if (int.TryParse(sMaxCap, out MaxCapDesired))
                {
                    if (MaxCapDesired <= 0)
                    {
                        Console.WriteLine("You cannot enter a negative  or zero value");
                    }
                    else
                    {
                        new Garage<Vehicles>(MaxCapDesired, GarageNameUserInput);
                    }
                }

                else
                {
                    Console.WriteLine("invalid input");
                }
                Console.WriteLine("PRESS 0 TO EXIT TO MAIN MENU");
                Console.WriteLine("PRESS 1 TO RCREATE YOUR GARAGE");
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
                Console.WriteLine("USE + TO ADD AND\n" +
                                  "USE - TO REMOVE\n" +
                                  "USE 0 TO EXIT TO MAIN MENU\n"+
                                  "USE 9 TO CLEAN THE WINDOW");
                string switchinput01 = Console.ReadLine();
                switch (switchinput01)
                {
                    case "+":
                        Console.WriteLine("TYPE 1 TO ADD CAR\n" +
                                      "TYPE 2 TO ADD BUS\n" +
                                      "TYPE 3 TO ADD MOTORCYCLE\n" +
                                      "TYPE 4 TO ADD BOAT\n" +
                                      "TYPE 5 TO ADD AIRPLANE\n" +
                                      "TYPE 0 TO EXIT TO MAIN MENU\n" +
                                      "TYPE 9 TO CLEAN THE WINDOW");
                        string input = Console.ReadLine();
                        Console.WriteLine("YOU CHOSE {0}\n ", input);
                        switch (input)
                        {

                            case "1": Console.WriteLine("YOU ARE WORKING WITH 1 CAR\n");
                                Car interfaceCar = new Car("Ayman", 111, "Rahol", 222);
                                Garage<Car> garageCar = new Garage<Car>(100, "USERINTERFACE GARAGENAME LINE 119");
                                garageCar.AddVehicle(interfaceCar);
                                break;
                            case "2": Console.WriteLine("YOU ARE WORKING WITH 2 BUS\n"); break;
                            case "3": Console.WriteLine("YOU ARE WORKING WITH 3 MOTORCYCLE\n"); break;
                            case "4": Console.WriteLine("YOU ARE WORKING WITH 4 BOAT\n"); break;
                            case "5": Console.WriteLine("YOU ARE WORKING WITH 5 AIRPLANE\n"); break;
                            case "0": Console.WriteLine("RETURN ONE STEP BACK\n"); return;
                            case "9": Console.WriteLine("CLEAN THE WINDOW"); Console.Clear(); break;
                            default: Console.WriteLine("INVALID INPUT! ENTER SOMETHING FROM OPTIONS\n"); break;


                        }
                        break;

                    case "-":
                        Console.WriteLine("!!!YOU ARE REMOVEING SOMETHING NOW!!!\n");
                        break;  
                    case "0":
                        return;
                    case "9":
                        Console.Clear();
                        break;
                    default:
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
