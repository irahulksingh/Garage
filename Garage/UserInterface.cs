using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage.Subclasses;

namespace Garage
{
 public class UserInterface:Vehicles
 {
        public void mainmenu()
        {
            Console.WriteLine("*************************************************\n              Garage Application \n*************************************************");
            Console.WriteLine("1. Create a Garage.");
            Console.WriteLine("2. Add or Remove vehicles.");
            Console.WriteLine("3. Show all vehicles");
            Console.WriteLine("0. Exit the program.");
            string sControl = Console.ReadLine();
            int iControl ;
            if(int.TryParse(sControl, out iControl))
            { 
            switch (iControl)
            {
                case 3: Allvehicles(); break;
                case 2: ParkOrUnpark(); break;
                case 1: CreateGarage(); break;
                case 0: return;
                default:Console.WriteLine("*****Please Enter a value from the above list *****"); Console.ReadLine(); break;
                }
            }
        }
   public void CreateGarage()
        {
            Console.Clear();
            Console.WriteLine("Create GARAGE\n**************************\n**************************");
            Console.WriteLine("What is your garage called :");
            string myGarage = Console.ReadLine();
            Console.WriteLine("How big do you want your garage :");
            string sMaxCap = Console.ReadLine();
            int MaxCapDesired;

            if (int.TryParse(sMaxCap,out MaxCapDesired))
            {
              new Garage<Vehicles>(MaxCapDesired,myGarage);
            }
            else
            {
                Console.WriteLine("invalid input"); }
                Console.ReadLine();
             }
        public void Allvehicles()
        {
            Console.Clear();
            Garage<Vehicles> Addnew = new Garage<Vehicles>();
            Vehicles newVeh = new Vehicles();
            newVeh.Name = "Test";
            newVeh.FuelType = "diesel";
            newVeh.NoOfEngines = 2;
            newVeh.NoOfSeats = 3;
            Addnew.AddVehicle(newVeh);

            foreach (int i  in newVeh)
            {

            }
            Console.WriteLine("");
            Console.ReadLine();
        }
        public void ParkOrUnpark()
        {
            Console.WriteLine("for Adding and Removing vehicles");
            Console.ReadLine();
        }
    }
}
