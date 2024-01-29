using System;

namespace techHub1._1
{
    // Numara oluşturma işlevlerini sağlayan sınıf
    public class NumberGenerator
    {
        // Yeni bir numara oluşturur ve onu bir string olarak döndürür
        public static string Create()
        {
            // Rastgele sayı oluşturmak için Random sınıfı kullanılır
            Random rnd = new Random();
            // 1000 ile 9999 arasında rastgele bir numara oluşturur
            int no = rnd.Next(1000, 10000);
            // Oluşturulan numarayı bir stringe dönüştürür
            string returnNo = no.ToString();
            // Oluşturulan numarayı döndürür
            return returnNo;
        }
    }
}
