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
        public int MaxCapDesired;
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
                Console.WriteLine("\n**************************\n CREATE GARAGE\n************************");
                Console.WriteLine("HOW BIG DO YOU WANT YOUR GARAGE TO BE :");
                string sMaxCap = Console.ReadLine();
              

                while (!int.TryParse(sMaxCap, out MaxCapDesired))
                {
                    if (MaxCapDesired <= 0)
                    {
                        Console.WriteLine("INVALID INPUT!!");
                    }
                   sMaxCap = Console.ReadLine();

                }
                new Garage<Vehicles>(MaxCapDesired);
                Console.ReadLine();
                Console.WriteLine("PRESS 0 TO EXIT TO MAIN MENU");
                Console.WriteLine("PRESS 1 TO RECREATE YOUR GARAGE");
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

                                Car newcar = new Car();
                                Console.WriteLine("What is the name of your car?");
                                var myCarname = Console.ReadLine();
                                newcar.Name =myCarname;
                                Console.WriteLine("What is the Fuel type for your car?");
                                var myCarFuel = Console.ReadLine();
                                newcar.FuelType = myCarFuel ;
                                Console.WriteLine("How many engines does your car has?");
                                var myCarEng =int.Parse (Console.ReadLine());
                                newcar.NoOfEngines = myCarEng;
                                Console.WriteLine("How many seats dows your Car has?");
                                var myCarseats =int.Parse(Console.ReadLine());
                                newcar.NoOfSeats   = myCarseats;
                                Garage<Car> garagecar = new Garage<Car>(MaxCapDesired);
                                garagecar.addtoList(newcar);



                                break;
                            case "2": Console.WriteLine("YOU ARE WORKING WITH 2 BUS\n");
                                Bus newBus = new Bus();
                                Console.WriteLine("What is the name of your Bus?");
                                var myBusname = Console.ReadLine();
                                newBus.Name = myBusname;
                                Console.WriteLine("What is the Fuel type for your Bus?");
                                var myBusFuel = Console.ReadLine();
                                newBus.FuelType = myBusFuel;
                                Console.WriteLine("How many engines does your Bus has?");
                                var myBusEng = int.Parse(Console.ReadLine());
                                newBus.NoOfEngines = myBusEng;
                                Console.WriteLine("How many seats dows your Bus has?");
                                var myBusseats = int.Parse(Console.ReadLine());
                                newBus.NoOfSeats = myBusseats;
                                Garage<Bus> garageBus = new Garage<Bus>(MaxCapDesired);
                                garageBus.addtoList(newBus);

                                break;
                            case "3": Console.WriteLine("YOU ARE WORKING WITH 3 MOTORCYCLE\n");
                                Motorcycle newMotorcycle = new Motorcycle();
                                Console.WriteLine("What is the name of your Motorcycle?");
                                var myMotorcyclename = Console.ReadLine();
                                newMotorcycle.Name = myMotorcyclename;
                                Console.WriteLine("What is the Fuel type for your Motorcycle?");
                                var myMotorcycleFuel = Console.ReadLine();
                                newMotorcycle.FuelType = myMotorcycleFuel;
                                Console.WriteLine("How many engines does your Motorcycle has?");
                                var myMotorcycleEng = int.Parse(Console.ReadLine());
                                newMotorcycle.NoOfEngines = myMotorcycleEng;
                                Console.WriteLine("How many seats dows your Motorcycle has?");
                                var myMotorcycleseats = int.Parse(Console.ReadLine());
                                newMotorcycle.NoOfSeats = myMotorcycleseats;
                                Garage<Motorcycle> garageMotorcycle = new Garage<Motorcycle>(MaxCapDesired);
                                garageMotorcycle.addtoList(newMotorcycle);
                                break;
                            case "4": Console.WriteLine("YOU ARE WORKING WITH 4 BOAT\n");
                                Boat newBoat = new Boat();
                                Console.WriteLine("What is the name of your Boat?");
                                var myBoatname = Console.ReadLine();
                                newBoat.Name = myBoatname;
                                Console.WriteLine("What is the Fuel type for your Boat?");
                                var myBoatFuel = Console.ReadLine();
                                newBoat.FuelType = myBoatFuel;
                                Console.WriteLine("How many engines does your Boat has?");
                                var myBoatEng = int.Parse(Console.ReadLine());
                                newBoat.NoOfEngines = myBoatEng;
                                Console.WriteLine("How many seats dows your Boat has?");
                                var myBoatseats = int.Parse(Console.ReadLine());
                                newBoat.NoOfSeats = myBoatseats;
                                Garage<Boat> garageBoat = new Garage<Boat>(MaxCapDesired);
                                garageBoat.addtoList(newBoat);
                                break;
                            case "5": Console.WriteLine("YOU ARE WORKING WITH 5 AIRPLANE\n");
                                Airplane newAirplane = new Airplane();
                                Console.WriteLine("What is the name of your Airplane?");
                                var myAirplanename = Console.ReadLine();
                                newAirplane.Name = myAirplanename;
                                Console.WriteLine("What is the Fuel type for your Airplane?");
                                var myAirplaneFuel = Console.ReadLine();
                                newAirplane.FuelType = myAirplaneFuel;
                                Console.WriteLine("How many engines does your Airplane has?");
                                var myAirplaneEng = int.Parse(Console.ReadLine());
                                newAirplane.NoOfEngines = myAirplaneEng;
                                Console.WriteLine("How many seats dows your Airplane has?");
                                var myAirplaneseats = int.Parse(Console.ReadLine());
                                newAirplane.NoOfSeats = myAirplaneseats;
                                Garage<Airplane> garageAirplane = new Garage<Airplane>(MaxCapDesired);
                                garageAirplane.addtoList(newAirplane);

                                break;
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
