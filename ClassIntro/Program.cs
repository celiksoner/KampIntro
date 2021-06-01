using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();

            kurs1.kursAdi = "C# Kursu";
            kurs1.egitmenAdi = "Soner Çelik";
            kurs1.izlenmeOrani = 123;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "SQL Kursu";
            kurs2.egitmenAdi = "Caner Çelik";
            kurs2.izlenmeOrani = 456;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Java Kursu";
            kurs3.egitmenAdi = "Aydın Kır";
            kurs3.izlenmeOrani = 789;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.egitmenAdi + " - " + kurs.izlenmeOrani);
            }

        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmenAdi { get; set; }
        public int izlenmeOrani { get; set; }
    }


}
