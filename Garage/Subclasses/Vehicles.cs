using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
   public class Vehicles
    {
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
            return "The Vehicle Name in the garage is :" + Name +
                "\nThe Vehicle in garage now has :" + NoOfEngines +
                "\nThis vehicel has a Fuel type of :" + FuelType +"\nThsi vehicle has" + NoOfSeats + " seats :" ;

        }

       }
}
