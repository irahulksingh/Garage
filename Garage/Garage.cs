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
       private List<T>maxvehicle;
        private int count;
        private int maxcapacity;
     

        private int MaxCapacity {get { return maxcapacity; } set { maxcapacity = value; } }
        public int Count {get { return count; }set { count = value; }}

        //public IEnumerator<T> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

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

