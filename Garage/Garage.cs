using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage.Subclasses;

namespace Garage
{
    public class Garage<T> : IEnumerable<T> where T : Vehicles
    {
        private List<T> maxvehicle;
        private int maxcapacity;
        private int count;

        Vehicles TestVeh = new Vehicles();
        Car NEWCar = new Car();

        public int MaxCapacity { get { return maxcapacity; } }
        public int Count { get { return count; } set { count = value; } }

        public Garage(int maxCapSetted)
        {
            maxvehicle = new List<T>();
            maxcapacity = maxCapSetted;
            Console.WriteLine("\n-------------------------------------------------------\n " +
                                "  GARAGE CREATED WITH A CAPACITY OF :" + maxcapacity + " VEHICLES" +
                               "\n-------------------------------------------------------");
            Console.ReadLine();
        }

        public Garage()
        {
        }

        public void addtoList(T input)
        {
            if (maxcapacity - maxvehicle.Count <= 0)
            {
                Console.WriteLine("-------------------------\n  SORRY  GARAGE  FULL\n------------------------");
                return;
            }
            if (count < maxcapacity)
            {
                maxvehicle.Add(input);
                count++;

            }
            Console.WriteLine("--------------------------------------\nYOUR GARAGE CAN HAVE :" + (maxcapacity - maxvehicle.Count) +
                " MORE VEHICLES\n-------------------------------------");
            Console.ReadLine();
        }
        public void RemoveVeh(T input)
        {
            if (maxvehicle.Count == 0)
            {
                Console.WriteLine("NO MORE VEHICLES TO REMOVE");
                return;
            }

            if (count <= maxcapacity)
            {
                string Regnotodel = input.Name;
                maxvehicle.RemoveAll(x => x.Name.StartsWith(Regnotodel));
                Console.WriteLine("Your have unparked a vehicle  :" + Regnotodel + "");
                count--;
            }
            Console.WriteLine("Your Garage can have :" + (maxcapacity - count) + " more Vehicles");
            Console.ReadLine();
        }


        public void AllVehicles()
        {
            //Car CarName = new Car();
            //Bus Busname = new Bus();
            if (maxvehicle.Count == 0)
            {
                Console.WriteLine("NO VEHICLES IN THE GARAGE");
            }
            else
            {
                foreach (var veh in maxvehicle)

                    Console.WriteLine(TestVeh.GarageInfo());
                //Console.WriteLine("vehicle Reg No:"+ veh.Name.ToString());
                Console.WriteLine("THE NUMBER OF VEHICLES IN THE GARAGE IS :" + maxvehicle.Count.ToString());

            }
            //Console.WriteLine("NO OF CARS IN THE GARAGE :" + CarName.Name.Count());//think about how to get a value of vehicle type from the garage class
            Console.ReadLine();
        }
        IEnumerator IEnumerable.GetEnumerator() { throw new NotImplementedException(); }
        public IEnumerator<T> GetEnumerator() { for (int i = 0; i < count; i++) { yield return maxvehicle[i]; } }
    }

}



