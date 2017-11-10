using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage.Subclasses;

namespace Garage
{
    /// <summary>
    /// GARAGE GENERIC CLASS. IT IS INHERETING FROM IENUMERABLE WHERE T ONHERET FROM CLASS VEHICLES. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Garage<T> : IEnumerable<T> where T : Vehicles
    {
        private List<T> maxvehicle;
        private int maxcapacity;
        private int count;


        public int MaxCapacity { get { return maxcapacity; } }
        public int Count { get { return count; } set { count = value; } }

        //public Garage()
        //{
        //}

        /// <summary>
        /// CTOR Garage INSTANSIATE "maxvhicle NEW GENERIC LIST"
        /// </summary>
        /// <param name="maxCapSetted" it is INT. WE ADD ITS VALUE TO maxcapacity></param>
        public Garage(int maxCapSetted)
        {
            maxvehicle = new List<T>();
            maxcapacity = maxCapSetted;
            Console.WriteLine("Your Garage size is :" + maxcapacity + " Vehicles");
        }

        /// <summary>
        /// addtoList METHOD TAKES T PARAMETER 
        /// </summary>
        /// <param name="input" IT IS GENERIC PARA></param>
        public void addtoList(T input)//name the method with capital letter
        {
            if (count < maxcapacity)
            {
                maxvehicle.Add(input);
                foreach (var i in maxvehicle)
                {
                    Console.WriteLine("Your have parked a  :" + i + "");
                }

            }
        }

        IEnumerator IEnumerable.GetEnumerator() { throw new NotImplementedException(); }
        public IEnumerator<T> GetEnumerator() { for (int i = 0; i < count; i++) { yield return maxvehicle[i]; } }
    }

}



