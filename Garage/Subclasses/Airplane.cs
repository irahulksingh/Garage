using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Subclasses
{
    public class Airplane:Vehicles
    {
        public Airplane()
        { }

        public Airplane(string name, int noeng, string ftype, int noseats)
        {
          
            Name = name;
            NoOfEngines = noeng;
            FuelType = ftype;
            NoOfSeats = noseats;

        }
        public override string GarageInfo()
        {

            return base.GarageInfo() + "\nTHIS VEHICLE IS A AIRPLANE \n------------------------------------";
            //"THE REG.NO OF THE AIRPLANE YOU HAVE PARKED IS :" + Name +
            //    "\nTHE NO. OF ENGINES IN THIS VEHICLE  :" + NoOfEngines +
            //    "\nTHIS VEHICLE RUNS ON :" + FuelType + "\nTHIS VEICLE HAS  ::" + NoOfSeats + " :: SEAT" + "\n ------------------------------------------------------------------";

        }
    }
   



}
