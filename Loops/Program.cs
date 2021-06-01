using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya giriş için temel kurs";
            string kurs3 = "Java";

            //Array - Diziler : Birden fazla nesne tutmak için kullanılır

            string[] kurslar = new string[] {
                "Yazılım geliştirici yetiştirme kampı",
                "Programlamaya giriş için temel kurs",
                "Java"
             };

            
            for (int i = 0; i < 3; i++)
            {           
                Console.WriteLine(kurslar[i]);
            }

            

            foreach  (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
