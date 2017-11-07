using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
   public class Vehicles
    {
        private int noofengines;
        private string fueltype;
        private int cylindervol;
        private int noofseats;
        private double vlength;

        public int NoOfEngines { get { return noofengines; } set { noofengines = value; } }
        public string FuelType { get { return fueltype; } set { fueltype = value; } }
        public int CylinderVol { get { return cylindervol; } set { cylindervol = value; } }
        public int NoOfSeats { get { return noofseats; } set { noofseats = value; } }
        public double vLength { get { return vlength; } set { vlength = value; } }

        public virtual string GarageInfo()
        {
            return "The Vehicle in garage now has :" + NoOfEngines +
                "\nThis vehicel has a Fuel type of :" + FuelType + "\nThe Cylinder volume of this vehicle is  :" + CylinderVol + "\nThsi vehicle has" + NoOfSeats + " seats :" + "\nThe Vehicle length is :" + vLength +"";

        }

    }
}
