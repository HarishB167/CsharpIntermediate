using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse.Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNUmber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNUmber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}
