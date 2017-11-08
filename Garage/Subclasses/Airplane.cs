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
    }
   



}
