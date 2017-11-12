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

        public Motorcycle(string name,int noeng, string ftype, int noseats,string vehtype)
        {

            VehTYPE = vehtype;
            Name = name;
            NoOfEngines = noeng;
            FuelType = ftype;                   
           NoOfSeats = noseats;
            
        }
        public override string GarageInfo()
        {
            return base.GarageInfo(); 

        }

    }
}
