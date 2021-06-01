using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikIslemleri
{
    class DortIslem
    {

        public void Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplama sonucu = " + sonuc);
        }

        public void Cikar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkarma sonucu = " + sonuc);
        }

        public void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpma sonucu = " + sonuc);
        }

        public void Bol(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("Bölme sonucu = " + sonuc);
        }



    }
}
