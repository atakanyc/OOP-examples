using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.id + " id li " + customer.CustomerNumber + " musteri numaralı lı musteri eklendi..");
        }
    }
}
