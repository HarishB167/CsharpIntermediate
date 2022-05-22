using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
            Orders = new List<Order>();
        }

        public void Promote()
        { 
        }
    }
}
