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
        private string garagename;
        private T[] maxvehicle;
        private int maxcapacity;
        private int count;

        public string GarageName { get { return garagename; } }
        public int MaxCapacity { get { return maxcapacity; } }
        public int Count { get { return count; } set { count = value; } }

        public Garage()
        {
        }
        public Garage(int maxCapSetted,string Garagename)
        {
            maxcapacity = maxCapSetted;
            garagename = Garagename;
           
            Console.WriteLine("Your Garage Name is :"+garagename) ;
            Console.WriteLine("Your Garage size is :" + maxcapacity);
            //Console.ReadLine();
        }

        public Garage(T input) {  maxvehicle = new T[maxcapacity]; }

        public void AddVehicle (T input) { if(count < maxcapacity) { maxvehicle[count++] = input; }}




        IEnumerator IEnumerable.GetEnumerator() { throw new NotImplementedException(); }
        public IEnumerator<T> GetEnumerator() { for (int i = 0; i < count; i++) { yield return maxvehicle[i]; } }
    }

}
    


