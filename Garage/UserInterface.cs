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
            Console.WriteLine("1. Show the number of vehicles in the garage with description.");
            Console.WriteLine("2. Show all the vehicle sorted with their types.");
            Console.WriteLine("3. Park or Unpark your vehicle. ");
            Console.WriteLine("4. Create a new garage.(The old one is full)");
            Console.WriteLine("0. Exit the program.");
            string sControl = Console.ReadLine();
            int iControl ;
            if(int.TryParse(sControl, out iControl))
            { 
            switch (iControl)
            {
                case 1: Allvehicles(); break;
                case 2: VehicleType(); break;
                case 3: ParkOrUnpark(); break;
                case 4: CreateGarage(); break;
                case 0: return;
                default:Console.WriteLine("*****Please Enter a value from the above list *****"); Console.ReadLine(); break;
                }
            }
        }
           
            
        public void CreateGarage()
        {
            Console.Clear();
            Console.WriteLine("How big do you want your garage :");
            string sMaxCap = Console.ReadLine();
            int MaxCapDesired;

            if (int.TryParse(sMaxCap,out MaxCapDesired))
            {
                GarageHandler mcDesired = new GarageHandler();
                mcDesired.MaxCapSetted = MaxCapDesired;
            }
            else
            {
                Console.WriteLine("invalid input"); }
                Console.ReadLine();
             }
        public void Allvehicles()
        {
            Console.WriteLine("for all vehicles");
            Console.ReadLine();
        }
        public void VehicleType()
        {
            Console.WriteLine("for vehicle type");
            Console.ReadLine();
        }
        public void ParkOrUnpark()
        {
            Console.WriteLine("for parking and unparking");
            Console.ReadLine();
        }
    }
}
