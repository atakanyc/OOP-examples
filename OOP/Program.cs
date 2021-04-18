using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Customer1 = new CoorporateCustomer(); //türemis tabana atanabilir
            Customer1.CustomerNumber = 1234;
            Customer1.id = 23;
            Customer Customer2 = new IndividualCustomer();
            Customer2.id = 345;
            Customer2.CustomerNumber = 23;

            CustomerManager manager = new CustomerManager();
            manager.Add(Customer1);
            manager.Add(Customer2);





        }
    }
}
