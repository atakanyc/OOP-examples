using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager homeCredit = new HomeCreditManager();
            ICreditManager carCredit = new CarCreditManager();

            ILoggerService databaseLogger = new DatabaseLoggerServices();
            ILoggerService fileloggerService = new FileLoggerServices();

          KrediBasvuruManager krediBasvuru = new KrediBasvuruManager();
            krediBasvuru.basvuru(homeCredit,databaseLogger);
            krediBasvuru.basvuru(carCredit,fileloggerService);

            Console.WriteLine("/////////////////////////////");

            List<ICreditManager> krediler = new List<ICreditManager> { homeCredit, carCredit };

            krediBasvuru.krediBilgilendirme(krediler);

        }
    }
}
