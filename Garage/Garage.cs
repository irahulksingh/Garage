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

        public int MaxCapacity { get { return maxcapacity; } }
        public int Count { get { return count; } set { count = value; } }

        public Garage(int maxCapSetted)
        {
            maxvehicle = new List<T>();
            maxcapacity = maxCapSetted;
            Console.WriteLine("Your Garage size is :" + maxcapacity + " Vehicles");

        }

        public Garage()
        {
        }

        public  void addtoList (T  input)
        {
            if (maxcapacity - maxvehicle.Count <= 0)
            {
                Console.WriteLine("++++++++++++++++++++++\n  SORRY  GARAGE  FULL\n++++++++++++++++++++++");
                return;
            }
            if (count < maxcapacity)
            { 
                maxvehicle.Add( input);
                foreach (var i in maxvehicle)
                {
                    Console.WriteLine("Your have parked a  :" + i.Name + "");
                 }
                
            }
            Console.WriteLine("Your Garage can have :" + (maxcapacity - maxvehicle.Count) + " more Vehicles");
            Console.ReadLine();
        }
        public void RemoveVeh(T input)
        {

            if (count < maxcapacity)
            {
                maxvehicle.Remove(input);
                foreach (var i in maxvehicle.Where(x => x.Name.StartsWith(x.Name))) 
                {
                    Console.WriteLine("Your have unparked a vehicle  :" + i.Name + "");
                }

            }
            Console.WriteLine("Your Garage can have :" + (maxcapacity) + " more Vehicles");
            Console.ReadLine();
       }

        public void AllVehicles()
        {
             if (maxvehicle.Count == 0)
            {
                Console.WriteLine("no vehicles in the garage");
            }
            else { 
            foreach (var veh in maxvehicle)
                        Console.WriteLine(veh);
                             
            }
            Console.ReadLine();
        }
       IEnumerator IEnumerable.GetEnumerator() { throw new NotImplementedException(); }
       public IEnumerator<T> GetEnumerator() { for (int i = 0; i < count; i++) { yield return maxvehicle[i]; } }

        }

}
    


