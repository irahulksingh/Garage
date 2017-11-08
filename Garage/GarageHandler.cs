using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage.Subclasses;

namespace Garage
{
 public class GarageHandler
    {
        private int maxcapset;

        public int MaxCapSetted {get { return maxcapset; }set { maxcapset = value; } }
        public void setMaxCap()
        {
           Garage<Vehicles> MaxCapSet = new Garage<Vehicles>(MaxCapSetted);
         }
    }

}
