using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class KrediBasvuruManager
    {
        public void basvuru(ICreditManager creditManager,ILoggerService loggerService)
        {
            creditManager.hesapla();

            loggerService.log();
        }


        public void krediBilgilendirme(List<ICreditManager> kredi)
        {
            foreach (var item in kredi)
            {
                item.hesapla();

            }
        }
    }
}
