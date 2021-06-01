using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.urunId = 1;
            urun1.urunAdi = "Elma";
            urun1.urunFiyati = 5;
            urun1.urunAciklamasi = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.urunId = 2;
            urun2.urunAdi = "Kayısı";
            urun2.urunFiyati = 4;
            urun2.urunAciklamasi = "Malatya Kayısı";

            Urun urun3 = new Urun();
            urun3.urunId = 3;
            urun3.urunAdi = "Karpuz";
            urun3.urunFiyati = 10;
            urun3.urunAciklamasi = "Adana Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2,urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.urunAdi);
                Console.WriteLine(urun.urunFiyati);
                Console.WriteLine(urun.urunAciklamasi);
                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine("\n\n-------------Metotlar---------------");

            // Instance - Örnek
            // Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);


            //Alternatif Ekleme Yöntemi
            //Bu yöntemin dezavantajı ilerleyen dönemde firma stok adedi eklemek isterse patlarız...
            sepetManager.Ekle2("Karpuz","Adana Karpuz",10);
            sepetManager.Ekle2("Elma", "Amasya Elması", 5);
            sepetManager.Ekle2("Kayısı", "Malatya Kayısı", 15);

        }
    }
}
