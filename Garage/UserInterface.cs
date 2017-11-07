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

            //Motorcycle Harley = new Motorcycle(2, "Diesel", 400, 2, 1.25);
            //Car Bentley = new Car(4, "Petrol", 800, 4, 2.4);
            //Boat Viraat = new Boat(20, "Diesel", 2000, 10, 5.25);
            //Airplane Jetty = new Airplane(4, "PowerPetrol", 5000, 200, 27);
            //Bus MyBus = new Bus(2, "Diesel", 1000, 50, 5.25);

            //Garage<Vehicles> vehicles;
            //vehicles = new Garage<Vehicles>();
            // foreach (var Veh in vehicles)
            //    {
            //     Console.WriteLine(Veh.GarageInfo());
            //    }

            Console.WriteLine("1. Show the number of vehicles in the garage with description.");
            Console.WriteLine("2. Show all the vehicle sorted with their types.");
            Console.WriteLine("3. Park or Unpark your vehicle. ");
            Console.WriteLine("4. Create a new garage.(The old one is full)");
            Console.WriteLine("0. Exit the program.");
            Console.ReadLine();
            

            int caseSwitch = 0;

            switch (caseSwitch)
            {
                case 1:
                    Allvehicles();
                    break;
                case 2:
                    break;
                case 3:

                    break;
                case 4:
                    CreateGarage();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("*****Please Enter a value from the above list *****");
                    break;
 
            }
           
            }
        public void CreateGarage()
        {
            Console.WriteLine("How big do you want your garage");
            int maxCap = int.Parse(Console.ReadLine());
        }
        public void Allvehicles()
        {
            Console.WriteLine("xxxxx");
            
        }
        public void VehicleType()
        {
            Console.WriteLine("yyyyy");
            
        }
        public void ParkOrUnpark()
        {
            Console.WriteLine("zzzzz");
           
        }
    }
}
