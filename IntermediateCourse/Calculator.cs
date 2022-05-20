using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
