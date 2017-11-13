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
        #region DECLARATION OF VARIABLE AND INSTANCE WHICH  CAN BE USED THROUGHOUT THIS CLASS
        public int MaxCapDesired;
        private Garage<Vehicles> allCapacity;
        #endregion
        #region MAIN MENU OPTIONS DISPLAY
        public void mainmenu()
        {

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------------------------------------\n" +
                    "--------------------------------------------------\n" +
                    "             MY GARAGE APPLICATION\n" +
                    "--------------------------------------------------\n" +
                    "--------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. CREATE A GARAGE.");
                Console.WriteLine("2. PARK OR UNPARK VEHICLES.");
                Console.WriteLine("3. SHOW ALL VEHICLES");
                Console.WriteLine("4. COUNT OF VEHICLES");
                Console.WriteLine("5. SEARCH VEHICLES");
                //Console.WriteLine("6. WHEELS");

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
                        case 4: Vehcount(); break;
                        case 5:SEARCHCRITERIA();break;
                        //case 6: Searchforwithwheels();break;
                        case 0: return;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-----PLEASE ENTER A VALUE FROM THE ABLOVE LIST ------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine(); break;
                    }
                }
            }
        }
        #endregion
        #region CREATE GARAGE METHOD
        public void CreateGarage()
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n------------------\n  CREATE GARAGE\n------------------");
                Console.ForegroundColor = ConsoleColor.White;
                CreateGarage:
                Console.WriteLine("HOW BIG DO YOU WANT YOUR GARAGE TO BE :");
                string sMaxCap = Console.ReadLine();
                if (sMaxCap == "0")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID INPUT. PLEASE ENTER A NON ZERO NUMBER!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    goto CreateGarage;
                }
                while (!int.TryParse(sMaxCap, out MaxCapDesired))
                {
                    if (MaxCapDesired < 0 || MaxCapDesired == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("INVALID INPUT. PLEASE ENTER A NON ZERO NUMBER!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        goto CreateGarage;
                    }
                    else
                    {
                        sMaxCap = Console.ReadLine();
                    }
                }
                allCapacity = new Garage<Vehicles>(MaxCapDesired);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("PRESS ENTER TO EXIT TO MAIN MENU");
                Console.WriteLine("PRESS R TO RECREATE YOUR GARAGE");
                Console.ForegroundColor = ConsoleColor.White;
                string inputForSwitch = Console.ReadLine();
                switch (inputForSwitch)
                {
                    case "R":
                        break;
                    default:
                        return;
                }
            }
        }
        #endregion
        #region SWITCH CASE FOR ADDING VEHICLES
        public void ParkOrUnpark()
        {
            Console.Clear();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("USE + TO ADD AND\n" +
                                  "USE - TO REMOVE\n" +
                                  "USE 0 TO EXIT TO MAIN MENU\n"
                                  );
                Console.ForegroundColor = ConsoleColor.White;

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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("------------------------------------------------" +
                                "\nNO GARAGE  EXISTs. PLEASE CREATE A GARAGE FIRST \n" +
                                "------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {

                            //  Garage<Vehicles> newGarage = new Garage<Vehicles>(MaxCapDesired);
                            switch (input)
                            {

                                case "1": //child case of "+" case
                                    Console.WriteLine("YOU ARE WORKING WITH 1 CAR\n");
                                    Car newcar = new Car();
                                    newcar.VehTYPE = "CAR";
                                    CarRegNo:
                                    Console.WriteLine("WHAT IS THE REG.NO OF THE VEHICLE?");
                                    var myCarname = Console.ReadLine();
                                    if (String.IsNullOrEmpty(myCarname))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("REG. NO. CANNOT BE EMPTY, PLEASE ENTER A REG. NO.");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto CarRegNo;
                                    }
                                    else
                                    {
                                        newcar.Name = myCarname;
                                    }
                                    Console.WriteLine("WHAT IS THE TYPE OF FUEL USED?");
                                    var myCarFuel = Console.ReadLine();
                                    newcar.FuelType = myCarFuel;
                                    CarEng:
                                    Console.WriteLine("HOW MANY ENGINES DOES THIS VEHICLE HAS?");
                                    string SmyCarEng = Console.ReadLine();
                                    int iMycareng;
                                    if (!int.TryParse(SmyCarEng, out iMycareng))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("NO. OF ENGINE MUST BE NUMERIC.PLEASE REENTER THE DETAILS.");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto CarEng;
                                    }
                                    else
                                    {
                                        newcar.NoOfEngines = iMycareng;
                                    }

                                    CarSeat:
                                    Console.WriteLine("HOW MANY SEATS DOES THIS VEHICLE HAS?");
                                    string myCarseats = Console.ReadLine();
                                    int imyCarSeats;
                                    if (!int.TryParse(myCarseats, out imyCarSeats))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("NO. OF SEATS MUST BE NUMERIC, PLEASE REENTER THE DETAILS.");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto CarSeat;
                                    }
                                    else
                                    {
                                        newcar.NoOfSeats = imyCarSeats;
                                        allCapacity.AddtoList(newcar);
                                    }

                                    break;
                                //
                                case "2"://child case of "+" case
                                    Console.WriteLine("YOU HAVE CHOOSEN BUS\n");
                                    Bus newBus = new Bus();
                                    newBus.VehTYPE = "BUS";
                                    BusRegno:
                                    Console.WriteLine("WHAT IS THE REG.NO OF THE VEHICLE?");
                                    string myBusname = Console.ReadLine();
                                    if (String.IsNullOrEmpty(myBusname))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("REG. NO. CANNOT BE EMPTY, PLEASE ENTER A REG. NO.");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto BusRegno;
                                    }
                                    else
                                    {
                                        newBus.Name = myBusname;
                                    }
                                    Console.WriteLine("WHAT IS THE TYPE OF FUEL USED?");
                                    var myBusFuel = Console.ReadLine();
                                    newBus.FuelType = myBusFuel;

                                    MyBUSengine:
                                    Console.WriteLine("HOW MANY ENGINES DOES THIS VEHICLE HAS?");
                                    string myBusEng = Console.ReadLine();
                                    int iMyBusEng;
                                    if (!int.TryParse(myBusEng, out iMyBusEng))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("NO. OF ENGINE MUST BE NUMERIC, PLEASE REENTER THE DETAILS");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto MyBUSengine;

                                    }
                                    else
                                    {
                                        newBus.NoOfEngines = iMyBusEng;
                                    }

                                    myBUSSEATNO:
                                    Console.WriteLine("HOW MANY SEATS DOES THIS VEHICLE HAS?");
                                    string myBusseats = Console.ReadLine();
                                    int imybusseats;
                                    if (!int.TryParse(myBusseats, out imybusseats))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("NO. OF ENGINE MUST BE NUMERIC, PLEASE REENTER THE DETAILS");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto myBUSSEATNO;

                                    }
                                    else
                                    {
                                        newBus.NoOfSeats = imybusseats;
                                        allCapacity.AddtoList(newBus);
                                    }
                                    break;
                                //
                                case "3"://child case of "+" case
                                    Console.WriteLine("YOU ARE WORKING WITH 3 MOTORCYCLE\n");
                                    Motorcycle newMotorcycle = new Motorcycle();
                                    newMotorcycle.VehTYPE = "MOTORCYCLE";
                                    mcregno:
                                    Console.WriteLine("WHAT IS THE REG.NO OF THE VEHICLE?");
                                    var myMotorcyclename = Console.ReadLine();
                                    if (String.IsNullOrEmpty(myMotorcyclename))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("REG. NO. CANNOT BE EMPTY, PLEASE ENTER A REG. NO.");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto mcregno;

                                    }
                                    newMotorcycle.Name = myMotorcyclename;
                                    Console.WriteLine("WHAT IS THE TYPE OF FUEL USED?");
                                    var myMotorcycleFuel = Console.ReadLine();
                                    newMotorcycle.FuelType = myMotorcycleFuel;

                                    myMCengno:
                                    Console.WriteLine("HOW MANY ENGINES DOES THIS VEHICLE HAS?");
                                    string myMotorcycleEng = Console.ReadLine();
                                    int iMymotorcycleeng;
                                    if (!int.TryParse(myMotorcycleEng, out iMymotorcycleeng))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("NO. OF ENGINE MUST BE NUMERIC, PLEASE REENTER THE DETAILS");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto myMCengno;
                                    }
                                    else
                                    {
                                        newMotorcycle.NoOfEngines = iMymotorcycleeng;
                                    }

                                    myMCSeatno:
                                    Console.WriteLine("HOW MANY SEATS DOES THIS VEHICLE HAS?");
                                    string myMotorcycleseats = Console.ReadLine();
                                    int imyMotorcycleseats;
                                    if (!int.TryParse(myMotorcycleseats, out imyMotorcycleseats))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("NO. OF SEATS MUST BE NUMERIC, PLEASE REENTER THE DETAILS");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto myMCSeatno;

                                    }
                                    else
                                    {
                                        newMotorcycle.NoOfSeats = imyMotorcycleseats;
                                        allCapacity.AddtoList(newMotorcycle);
                                    }
                                    break;
                                //
                                case "4"://child case of "+" case
                                    Console.WriteLine("YOU ARE WORKING WITH 4 BOAT\n");
                                    Boat newBoat = new Boat();
                                    newBoat.VehTYPE = "BOAT";
                                    newBoatReg:
                                    Console.WriteLine("WHAT IS THE REG.NO OF THE VEHICLE?");
                                    var myBoatname = Console.ReadLine();
                                    if (String.IsNullOrEmpty(myBoatname))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("REG. NO. CANNOT BE EMPTY, PLEASE ENTER A REG. NO.");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto newBoatReg;
                                    }
                                    newBoat.Name = myBoatname;
                                    Console.WriteLine("WHAT IS THE TYPE OF FUEL USED?");
                                    var myBoatFuel = Console.ReadLine();
                                    newBoat.FuelType = myBoatFuel;

                                    mynewBoat:
                                    Console.WriteLine("HOW MANY ENGINES DOES THIS VEHICLE HAS? ");
                                    string myBoatEng = Console.ReadLine();
                                    int iMynewboat;
                                    if (!int.TryParse(myBoatEng, out iMynewboat))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("NO. OF ENGINE MUST BE NUMERIC, PLEASE REENTER THE DETAILS");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto mynewBoat;
                                    }
                                    else
                                    {
                                        newBoat.NoOfEngines = iMynewboat;
                                    }
                                    mynewboatseats:
                                    Console.WriteLine("HOW MANY SEATS DOES THIS VEHICLE HAS?");
                                    string myBoatseats = Console.ReadLine();
                                    int imyBoatseats;
                                    if (!int.TryParse(myBoatseats, out imyBoatseats))

                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("NO. OF SEATS MUST BE NUMERIC, PLEASE REENTER THE DETAILS");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto mynewboatseats;


                                    }
                                    else
                                    {
                                        newBoat.NoOfSeats = imyBoatseats;
                                        allCapacity.AddtoList(newBoat);
                                    }
                                    break;

                                case "5"://child case of "+" case
                                    Console.Write("YOU ARE WORKING WITH 5 AIRPLANE\n");
                                    Airplane newAirplane = new Airplane();
                                    newAirplane.VehTYPE = "AIRPLANE";
                                    newAPregno:
                                    Console.Write("WHAT IS THE REG.NO OF THE VEHICLE?");
                                    var myAirplanename = Console.ReadLine();
                                    if (string.IsNullOrEmpty(myAirplanename))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("REG. NO. CANNOT BE EMPTY, PLEASE ENTER A REG. NO.");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto newAPregno;
                                    }
                                    newAirplane.Name = myAirplanename;
                                    Console.Write("WHAT IS THE TYPE OF FUEL USED?");
                                    var myAirplaneFuel = Console.ReadLine();
                                    newAirplane.FuelType = myAirplaneFuel;

                                    APengno:
                                    Console.Write("HOW MANY ENGINES DOES THIS VEHICLE HAS?");
                                    string myAirplaneEng = Console.ReadLine();
                                    int iMyAPeng;
                                    if (!int.TryParse(myAirplaneEng, out iMyAPeng))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("NO. OF ENGINE MUST BE NUMERIC, PLEASE REENTER THE DETAILS");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto APengno;

                                    }
                                    else
                                    {
                                        newAirplane.NoOfEngines = iMyAPeng;
                                    }

                                    myApSeats:
                                    Console.Write("HOW MANY SEATS DOES THIS VEHICLE HAS?");
                                    string myAirplaneseats = Console.ReadLine();
                                    int imyapseats;
                                    if (!int.TryParse(myAirplaneseats, out imyapseats))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("NO. OF SEATS MUST BE NUMERIC, PLEASE REENTER THE DETAILS");
                                        Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto myApSeats;

                                    }
                                    else
                                    {
                                        newAirplane.NoOfSeats = imyapseats;
                                        allCapacity.AddtoList(newAirplane);
                                    }
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
                        switch (input1)
                        {
                            case "1":
                                Console.WriteLine("GIVE THE REG.NO. OF THE CAR YOU WANT TO UNPARK!!!\n");
                                Car rnewCar = new Car();
                                Console.Write("WHAT IS THE REG. NO OF YOUR CAR ?");
                                var rmyCarname = Console.ReadLine();
                                rnewCar.Name = rmyCarname;
                                if (allCapacity != null)
                                {
                                    allCapacity.RemoveVeh(rnewCar);
                                }
                                else 
                                {
                                    Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\nNo CAR with this REG. No in the garage\n++++++++++++++++++++++++++++++++++++++++");

                                }
                                break;
                            case "2":
                                Bus rnewBus = new Bus();
                                Console.Write("WHAT IS THE REG. NO. OF YOUR BUS ?");
                                var rmyBusname = Console.ReadLine();
                                rnewBus.Name = rmyBusname;
                                if (rnewBus.Name == rmyBusname)
                                {
                                    allCapacity.RemoveVeh(rnewBus);
                                }
                                else
                                {
                                    Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\nNo BUS with this REG. No in the garage\n++++++++++++++++++++++++++++++++++++++++");
                                }
                                break;
                            case "3":
                                Motorcycle rnewMC = new Motorcycle();
                                Console.Write("WHAT IS THE REG. NO OF YOUR MOTORCYCLE ?");
                                var rnewMC1 = Console.ReadLine();
                                rnewMC.Name = rnewMC1;

                                if (rnewMC.Name == rnewMC1)
                                {
                                    allCapacity.RemoveVeh(rnewMC);
                                }
                                else
                                {
                                    Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\nNo MOTORCYCLE with this REG. No in the garage\n++++++++++++++++++++++++++++++++++++++++");
                                }
                                break;
                            case "4":
                                Boat rnewBoat = new Boat();
                                Console.Write("WHAT IS THE REG. NO. OF YOUR BOAT ?");
                                var rnewBoat1 = Console.ReadLine();
                                rnewBoat.Name = rnewBoat1;
                                if (rnewBoat.Name == rnewBoat1)
                                {
                                    allCapacity.RemoveVeh(rnewBoat);
                                }
                                else
                                {
                                    Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\nNo MOTORCYCLE with this REG. No in the garage\n++++++++++++++++++++++++++++++++++++++++");
                                }
                                break;
                            case "5":
                                Airplane rnewAP = new Airplane();
                                Console.Write("WHAT IS THE REG. NO. OF YOUR AIRPLANE ?");
                                var rnewAP1 = Console.ReadLine();
                                rnewAP.Name = rnewAP1;
                                if (rnewAP.Name == rnewAP1)
                                {
                                    allCapacity.RemoveVeh(rnewAP);
                                }
                                else
                                {
                                    Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++\nNo MOTORCYCLE with this REG. No in the garage\n++++++++++++++++++++++++++++++++++++++++");
                                }
                                break;
                        }
                        break;
                    case "0":
                        return;


                }
            }
        }
        #endregion 
        #region DISPLAY ALL VEHICLES WITH PROPERTIES BY CALLING GARAGE INFO FROM VEHICLES CLASS WHICH IS OVERRIDDEN BY INDIVIDUAL CLASS GARAGEINFO METHOD

        public void ShowAllVehicles()
        {
            if (allCapacity == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SORRY !! NO VEHICLES TO DISPLAY, NO GARAGE NO VEHICLE :(");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
            else
            {
                foreach (var Veh in allCapacity)
                {
                    Console.WriteLine(Veh.GarageInfo());
                }
                Console.ReadLine();
            }
        }
        #endregion

        public void ClearList()
        {
            if (allCapacity == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO GARAGE EXISTS TO DELETE !!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
            else
            {
                allCapacity.Clearall();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GARAGE DELETED !!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
        }

        #region DIPLAY COUNT OF VEHICLES BY CALLING METHOD FROM GARAGE CLASS



        public void Vehcount()
        {
            if (allCapacity != null)
            {
                allCapacity.VEHICLECOUNTS();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SORRY !! NO VEHICLES TO DISPLAY, NO GARAGE NO VEHICLE :(");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        #endregion

        #region SEARCH FOR A VEHICLE
        public void SearchforaVehicle()
        {
            Vehicles searchveh = new Vehicles();
            Console.Clear();
            Console.WriteLine("PLEASE ENTER THE FUEL TYPE FOR THE VEHICLE TO SEARCH :");
            string Searchfor = Console.ReadLine();
            searchveh.FuelType = Searchfor;
            //searchveh.Name = Searchfor;
            if (allCapacity != null)
            {
                allCapacity.SearchRegNo(searchveh);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO VEHICLES IN THE GARAGE");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }



        }
        public void Searchforwithwheels()
        {
            Vehicles searchveh = new Vehicles();
            Console.Clear();
            Console.WriteLine("PLEASE ENTER THE NO OF SEATS IN A VEHICLE TO SEARCH FOR :");
            string Searchforseats = Console.ReadLine();
            int iSearchforseats;

            if (int.TryParse(Searchforseats,out iSearchforseats))
            {
                searchveh.NoOfSeats = iSearchforseats;
                if (allCapacity != null)
                {
                    allCapacity.SearchbyseatNo(searchveh);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO VEHICLES IN THE GARAGE");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
            }

               }
        #endregion  
        public void SEARCHCRITERIA()
        {
            Console.Clear();
            Console.WriteLine("PLEASE SELECT THE SEARCH CRITERIA ");
            Console.WriteLine("1. SEARCH BY FUEL TYPE ");
            Console.WriteLine("2. SEARCH BY NO. OF SEATS ");
            Console.WriteLine("0. EXIT ");

            string sCriteria = Console.ReadLine();

            switch(sCriteria)
            { 
                case "1":SearchforaVehicle();
                break;
                case "2":Searchforwithwheels();
                    break;
                case "0":
                    return;
                default:
                    break;
            }



        }


    }

}





