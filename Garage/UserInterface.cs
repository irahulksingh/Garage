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
        private Garage<Vehicles> allCapacity;
        #region Main Menu 
        public void mainmenu()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("*************************************************\n             MY GARAGE APPLICATION\n*************************************************");
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
                        case 3: ShowAllVehicles(); break;
                        case 0: return;
                        default: Console.WriteLine("*****PLEASE ENTER A VALUE FROM THE ABLOVE LIST *****"); Console.ReadLine(); break;
                    }
                }
            }
        }
        #endregion
        #region CreateGarage
        public void CreateGarage()
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n**************************\n CREATE GARAGE\n************************");
                Console.WriteLine("HOW BIG DO YOU WANT YOUR GARAGE TO BE :");
                string sMaxCap = Console.ReadLine();
                if(sMaxCap == "0")
                {
                    Console.WriteLine("GARAGE SIZE CANNOT BE ZERO !!");
                    Console.ReadLine();
                    return;
                }
                while (!int.TryParse(sMaxCap, out MaxCapDesired))
                {
                    if (MaxCapDesired <= 0)
                    {
                        Console.WriteLine("INVALID INPUT!!");
                    }
                    sMaxCap = Console.ReadLine();
                }
                allCapacity = new Garage<Vehicles>(MaxCapDesired);
                //Console.ReadLine();
                Console.WriteLine("PRESS ENTER TO EXIT TO MAIN MENU");
                Console.WriteLine("PRESS 0 TO RECREATE YOUR GARAGE");
                string inputForSeitch = Console.ReadLine();
                switch (inputForSeitch)
                {
                    case "0":
                        break;
                    default:
                        return;
                }
            }
        }
        #endregion
        #region Park and unpark vehicles
        public void ParkOrUnpark()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("USE + TO ADD AND\n" +
                                  "USE - TO REMOVE\n" +
                                  "USE 0 TO EXIT TO MAIN MENU\n"
                                /*  "USE 9 TO CLEAN THE WINDOW*/);
                
                string switchinput01 = Console.ReadLine();
                Console.Clear();
                switch (switchinput01)
                {
                    case "+":// mother case
                        Console.WriteLine("TYPE 1 TO ADD CAR\n" +
                                      "TYPE 2 TO ADD BUS\n" +
                                      "TYPE 3 TO ADD MOTORCYCLE\n" +
                                      "TYPE 4 TO ADD BOAT\n" +
                                      "TYPE 5 TO ADD AIRPLANE\n" +
                                      "TYPE 0 TO EXIT TO MAIN MENU\n"
                                      /*"TYPE 9 TO CLEAN THE WINDOW*/);
                        string input = Console.ReadLine();
                      //  Console.WriteLine("YOU CHOOSE {0}\n ", input);

                        if (MaxCapDesired <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("++++++++++++++++++++++\n NO GARAGE  EXISTS\n" +
                                "CREATE A GARAGE FIRST \n++++++++++++++++++++++");
                        }
                        else
                        {
#region SWITCH CASE FOR ADDING VEHICLES
                            //  Garage<Vehicles> newGarage = new Garage<Vehicles>(MaxCapDesired);
                            switch (input)
                            {

                                case "1": //child case of "+" case
                                    Console.WriteLine("YOU ARE WORKING WITH 1 CAR\n");
                                    Car newcar = new Car();
                                    newcar.VehTYPE = "CAR";
                                    Console.WriteLine("WHAT IS THE REG.NO OF THE VEHICLE?");
                                    var myCarname = Console.ReadLine();
                                    newcar.Name = myCarname;
                                    Console.WriteLine("WHAT IS THE TYPE OF FUEL USED?");
                                    var myCarFuel = Console.ReadLine();
                                    newcar.FuelType = myCarFuel;
                                    Console.WriteLine("HOW MANY ENGINES DOES THIS VEHICLE HAS?");
                                    string SmyCarEng = Console.ReadLine();
                                    int iMycareng;
                                    if (!int.TryParse(SmyCarEng, out iMycareng))
                                    {
                                        Console.WriteLine("NUMBER OF ENGINE SHOULD BE NUMERIC");
                                        break;
                                    }
                                    else
                                    {
                                        newcar.NoOfEngines = iMycareng;
                                    }
                                    Console.WriteLine("HOW MANY SEATS DOES THIS VEHICLE HAS?");
                                    var myCarseats = int.Parse(Console.ReadLine());
                                    newcar.NoOfSeats = myCarseats;
                                    allCapacity.addtoList(newcar);
                                    //Console.WriteLine("YOU HAVE PARKED \n"+newcar.GarageInfo());
                                    break;
                                //
                                case "2"://child case of "+" case
                                    Console.WriteLine("YOU ARE WORKING WITH 2 BUS\n");
                                    Bus newBus = new Bus();
                                    newBus.VehTYPE = "BUS";
                                    Console.WriteLine("WHAT IS THE REG.NO OF THE VEHICLE?");
                                    var myBusname = Console.ReadLine();
                                    newBus.Name = myBusname;
                                    Console.WriteLine("WHAT IS THE TYPE OF FUEL USED?");
                                    var myBusFuel = Console.ReadLine();
                                    newBus.FuelType = myBusFuel;
                                    Console.WriteLine("HOW MANY ENGINES DOES THIS VEHICLE HAS?");
                                    var myBusEng = int.Parse(Console.ReadLine());
                                    newBus.NoOfEngines = myBusEng;
                                    Console.WriteLine("HOW MANY SEATS DOES THIS VEHICLE HAS?");
                                    var myBusseats = int.Parse(Console.ReadLine());
                                    newBus.NoOfSeats = myBusseats;
                                    allCapacity.addtoList(newBus);
                                    break;
                                //
                                case "3"://child case of "+" case
                                    Console.WriteLine("YOU ARE WORKING WITH 3 MOTORCYCLE\n");
                                    Motorcycle newMotorcycle = new Motorcycle();
                                    newMotorcycle.VehTYPE = "MOTORCYCLE";
                                    Console.WriteLine("WHAT IS THE REG.NO OF THE VEHICLE?");
                                    var myMotorcyclename = Console.ReadLine();
                                    newMotorcycle.Name = myMotorcyclename;
                                    Console.WriteLine("WHAT IS THE TYPE OF FUEL USED?");
                                    var myMotorcycleFuel = Console.ReadLine();
                                    newMotorcycle.FuelType = myMotorcycleFuel;
                                    Console.WriteLine("HOW MANY ENGINES DOES THIS VEHICLE HAS?");
                                    var myMotorcycleEng = int.Parse(Console.ReadLine());
                                    newMotorcycle.NoOfEngines = myMotorcycleEng;
                                    Console.WriteLine("HOW MANY SEATS DOES THIS VEHICLE HAS?");
                                    var myMotorcycleseats = int.Parse(Console.ReadLine());
                                    newMotorcycle.NoOfSeats = myMotorcycleseats;
                                    allCapacity.addtoList(newMotorcycle);
                                    break;
                                //
                                case "4"://child case of "+" case
                                    Console.WriteLine("YOU ARE WORKING WITH 4 BOAT\n");
                                    Boat newBoat = new Boat();
                                    newBoat.VehTYPE = "BOAT";
                                    Console.WriteLine("WHAT IS THE REG.NO OF THE VEHICLE?");
                                    var myBoatname = Console.ReadLine();
                                    newBoat.Name = myBoatname;
                                    Console.WriteLine("WHAT IS THE TYPE OF FUEL USED?");
                                    var myBoatFuel = Console.ReadLine();
                                    newBoat.FuelType = myBoatFuel;
                                    Console.WriteLine("HOW MANY ENGINES DOES THIS VEHICLE HAS? ");
                                    var myBoatEng = int.Parse(Console.ReadLine());
                                    newBoat.NoOfEngines = myBoatEng;
                                    Console.WriteLine("HOW MANY SEATS DOES THIS VEHICLE HAS?");
                                    var myBoatseats = int.Parse(Console.ReadLine());
                                    newBoat.NoOfSeats = myBoatseats;
                                    allCapacity.addtoList(newBoat);
                                    break;

                                case "5"://child case of "+" case
                                    Console.Write("YOU ARE WORKING WITH 5 AIRPLANE\n");
                                    Airplane newAirplane = new Airplane();
                                    newAirplane.VehTYPE = "AIRPLANE";
                                    Console.Write("WHAT IS THE REG.NO OF THE VEHICLE?");
                                    var myAirplanename = Console.ReadLine();
                                    newAirplane.Name = myAirplanename;
                                    Console.Write("WHAT IS THE TYPE OF FUEL USED?");
                                    var myAirplaneFuel = Console.ReadLine();
                                    newAirplane.FuelType = myAirplaneFuel;
                                    Console.Write("HOW MANY ENGINES DOES THIS VEHICLE HAS?");
                                    var myAirplaneEng = int.Parse(Console.ReadLine());
                                    newAirplane.NoOfEngines = myAirplaneEng;
                                    Console.Write("HOW MANY SEATS DOES THIS VEHICLE HAS?");
                                    var myAirplaneseats = int.Parse(Console.ReadLine());
                                    newAirplane.NoOfSeats = myAirplaneseats;
                                    allCapacity.addtoList(newAirplane);
                                    break;
                                //
                                case "0"://child case of "+" case
                                    Console.WriteLine("RETURN ONE STEP BACK\n");
                                    return;
                                //
                                case "9":
                                    Console.WriteLine("CLEAN THE WINDOW");
                                    Console.Clear();
                                    break;
                                //
                                default://child case of "+" case
                                    Console.WriteLine("INVALID INPUT! ENTER SOMETHING FROM OPTIONS\n");
                                    break;
                                    //
                            }
                        }
                        break;// this is for +
#endregion SWITCH CASE FOR ADDING VEHICLES END HERE

#region SWITCH CASE FOR REMOVING VEHICLES
                    case "-":
                        Console.WriteLine("TYPE 1 TO REMOVE CAR\n" +
                                      "TYPE 2 TO REMOVE BUS\n" +
                                      "TYPE 3 TO REMOVE MOTORCYCLE\n" +
                                      "TYPE 4 TO REMOVE BOAT\n" +
                                      "TYPE 5 TO REMOVE AIRPLANE\n" +
                                      "TYPE 0 TO EXIT TO MAIN MENU\n"
                                      /*"TYPE 9 TO CLEAN THE WINDOW*/);
                        string input1 = Console.ReadLine();
                        switch(input1)
                        {
                            case "1":
                                Console.WriteLine("GIVE THE REG.NO. OF THE CAR YOU WANT TO UNPARK!!!\n");
                                Car rnewCar = new Car();
                                Console.Write("WHAT IS THE RREG. NO OF YOUR CAR ?");
                                var rmyCarname = Console.ReadLine();
                                rnewCar.Name = rmyCarname;
                                //if (rnewCar.Name == rmyCarname)
                                //{
                                    allCapacity.RemoveVeh(rnewCar);
                                //}
                                //else
                                //{
                                //    Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\nNo CAR with this REG. No in the garage\n++++++++++++++++++++++++++++++++++++++++");

                                //}
                                break;
                            case "2":
                                Bus rnewBus = new Bus();
                                Console.Write("WHAT IS THE REG. NO. OF YOUR BUS ?");
                                var rmyBusname = Console.ReadLine();
                                rnewBus.Name = rmyBusname;
                                //if(rnewBus.Name == rmyBusname)
                                //{
                                    allCapacity.RemoveVeh(rnewBus);
                                //}
                                //else
                                //{
                                //    Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\nNo BUS with this REG. No in the garage\n++++++++++++++++++++++++++++++++++++++++");
                                //}
                                break;
                            case "3":
                                Motorcycle rnewMC = new Motorcycle();
                                Console.Write("WHAT IS THE REG. NO OF YOUR MOTORCYCLE ?");
                                var rnewMC1 = Console.ReadLine();
                                rnewMC.Name = rnewMC1;

                                //if (rnewMC.Name == rnewMC1)
                                //{
                                allCapacity.RemoveVeh(rnewMC);
                                //}
                                //else
                                //{
                                //    Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\nNo MOTORCYCLE with this REG. No in the garage\n++++++++++++++++++++++++++++++++++++++++");
                                //}
                                break;
                            case "4":
                                Boat rnewBoat = new Boat();
                                Console.Write("WHAT IS THE REG. NO. OF YOUR BOAT ?");
                                var rnewBoat1 = Console.ReadLine();
                                rnewBoat.Name = rnewBoat1;
                                //if (rnewMC.Name == rnewMC1)
                                //{
                                allCapacity.RemoveVeh(rnewBoat);
                                //}
                                //else
                                //{
                                //    Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\nNo MOTORCYCLE with this REG. No in the garage\n++++++++++++++++++++++++++++++++++++++++");
                                //}
                                break;
                            case "5":
                                Airplane rnewAP= new Airplane();
                                Console.Write("WHAT IS THE REG. NO. OF YOUR AIRPLANE ?");
                                var rnewAP1 = Console.ReadLine();
                                rnewAP.Name = rnewAP1;
                                //if (rnewMC.Name == rnewMC1)
                                //{
                                allCapacity.RemoveVeh(rnewAP);
                                //}
                                //else
                                //{
                                //    Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\nNo MOTORCYCLE with this REG. No in the garage\n++++++++++++++++++++++++++++++++++++++++");
                                //}
                                break;
                        }
                        break;
                    case "0":
                        return;


                }
            }
        }
#endregion SWITCH CASE FOR REMOVING VEHICLES END HERE
        public void ShowAllVehicles()
        {
            if(allCapacity==null)
            {
                Console.Clear();
                Console.WriteLine("SORRY !! NO VEHICLES TO DISPLAY, NO GARAGE NO VEHICLE :(");
                Console.ReadLine();
            }
            else {
                foreach (var Veh in allCapacity)
                {
                    //Console.Clear();
                    Console.WriteLine(Veh.GarageInfo());
                    
                }
                //allCapacity.AllVehicles();
                Console.ReadLine();
            }
           


        }
    }
}





#endregion