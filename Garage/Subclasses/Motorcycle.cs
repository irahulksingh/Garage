using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Subclasses
{
   public class Motorcycle:Vehicles
    {
        public Motorcycle()
        { }

        public Motorcycle(int noeng, string ftype, int cvol, int noseats, double vlen)
        {
            NoOfEngines = noeng;
            FuelType = ftype;
            CylinderVol = cvol;
            NoOfSeats = noseats;
            vLength = vlen;
        }

    }
}
