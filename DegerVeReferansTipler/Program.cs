using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Değer Tip Değişken - Atama yapıldıktan sonra değeri değiştirirsek bile değişmez cevap 30'dur.
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1);


            //Referans Tip Değişken - Değeri programın ilerisinde değiştirirsek gerideki ypaılan atamada değişir. Cevap 999'dur.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;

            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]);

            // int , decimal , float , double , bool = Değer Tip
            // array , class , interface = Referans Tip



        }
    }
}
