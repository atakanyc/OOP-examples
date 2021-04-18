using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class DatabaseLoggerServices : ILoggerService
    {
       public void  log()
        {
            Console.WriteLine("veritabanı loglandı");
        }


    }
}
