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

        Motorcycle Harley = new Motorcycle(2, "Diesel", 400, 2, 1.25);
        Car Bentley = new Car(4, "Petrol", 800, 4, 2.4);
        Boat Viraat = new Boat(20, "Diesel", 2000, 10, 5.25);
        Airplane Jetty = new Airplane(4, "PowerPetrol", 5000, 200, 27);
        Bus MyBus = new Bus(2, "Diesel", 1000, 50, 5.25);

        Garage<Vehicles> vehicles;
        vehicles = new Garage<Vehicles>();


            foreach (var Veh in vehicles)
            {
                Console.WriteLine(Veh.GarageInfo());
            }


    Console.ReadLine();


        }

    }
}
