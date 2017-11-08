using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Subclasses
{
  public  class Car:Vehicles
    {
        public Car()
        { }
        public Car(string name, int noeng, string ftype, int noseats)
        {
            Name = name;
            NoOfEngines = noeng;
            FuelType = ftype;
            NoOfSeats = noseats;

        }
    }
}
