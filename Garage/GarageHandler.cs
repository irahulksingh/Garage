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

        public int MaxCapSetted
        {
            get { return maxcapset; }
            set { maxcapset = value; }
        }


        public void setMaxCap()
        {
           // Garage<UserInterface> vehmax = new Garage<UserInterface>();

            Garage<Vehicles> MaxCapSet = new Garage<Vehicles>();
            MaxCapSet.MaxCapacity = MaxCapSetted;

                              
        }
    }

}
