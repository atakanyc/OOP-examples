using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //interface leri birbirinin alternatifi olan ama kod içerikleri
    //farklı olan durumlar için kullanıyoruz

    // dosyaya yazma, veritabanına yazma, sms atma, mail atma .Yapılan ortak iş loglamadır
    //Fakat mail atmak için kullandığımız kod içeriğiyle dosyaya yazmak 
    //için kullandığımız içerik farklıdır
    interface ICreditManager
    {
        public void hesapla();
    }
}

