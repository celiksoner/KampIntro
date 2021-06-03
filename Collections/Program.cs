using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ctrl + k + c Toplu olarak yorum satırı yapıyor ctrl + k + u kaldırıyor
            //Array'ler sadece belirlenen sınırlarda kullanılabilir. Fazladan bir eleman daha eklenemez.
            //string[] isimler = new string[] { "Soner", "Caner", "Sakine", "Alpay" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //Bu şekilde limit arttırma olayı denenebilir fakat geride kalan elemanlar silinir.
            //isimler = new string[5];




            List<string> isimler2 = new List<string> { "Soner", "Caner" , "Sakine" , "Alpay"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
