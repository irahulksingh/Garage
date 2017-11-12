using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
   public class Vehicles
    {
        private string vehtype;

        public string VehTYPE
        {
            get { return vehtype; }
            set { vehtype = value; }
        }

        private string  name;    
        private int noofengines;
        private string fueltype;
        private int noofseats;

        public string Name { get { return name; } set { name = value; } }

        public int NoOfEngines { get { return noofengines; } set { noofengines = value; } }
        public string FuelType { get { return fueltype; } set { fueltype = value; } }
        public int NoOfSeats { get { return noofseats; } set { noofseats = value; } }
       
        public virtual string GarageInfo()

      {
            
            Console.ForegroundColor = ConsoleColor.Green;
            return
                "\n-------------------------------------------------------" +
                "\n-------------------------------------------------------\n"+
                "THIS VEHICLE IS A : " + VehTYPE+
                "\nTHE REG.NO OF THE CAR YOU HAVE PARKED IS :" + Name +
               "\nTHE NO. OF ENGINES IN THIS VEHICLE  :" + NoOfEngines +
                "\nTHIS VEHICLE RUNS ON :" + FuelType + "\nTHIS VEHICLE HAS  ::" + NoOfSeats + " :: SEAT" +
                "\n-------------------------------------------------------"+
                "\n-------------------------------------------------------"
                ;
            
        }


    }
}
