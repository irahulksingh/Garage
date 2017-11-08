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
