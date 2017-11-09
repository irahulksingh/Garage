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

                if (int.TryParse(sMaxCap, out MaxCapDesired))// Ayman. Take care for nigative input in sMaxCap. Capacity can not be nigative.
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

            Motorcycle moto = new Motorcycle("harley", 2, "petrol", 1);
            Garage<Vehicles> Addnew = new Garage<Vehicles>(moto);
            Addnew.AddVehicle(moto);
            foreach (var i in Addnew)
            {
                Console.WriteLine(i.GarageInfo());
            }
            //Console.WriteLine("");
            Console.ReadLine();
        }

        /// <summary>
        /// WHAT IS THE POINT OF THIS METHOD???
        /// </summary>
        public void Allvehicles()
        {
            Console.WriteLine("YOUR GARAGE NAME IS SIZE IS ");

        }

    }
}
