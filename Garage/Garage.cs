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
            maxcapacity = maxCapSetted;
            Console.WriteLine("your garage size is :" + maxcapacity);
            Console.ReadLine();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return maxvehicle[i];
            }
        }


    }

}
    


