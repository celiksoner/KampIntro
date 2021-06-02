using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.UrunId = 1;
            urun1.UrunAdi = "Elma";
            urun1.UrunFiyati = 5;
            urun1.UrunAciklamasi = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.UrunId = 2;
            urun2.UrunAdi = "Kayısı";
            urun2.UrunFiyati = 4;
            urun2.UrunAciklamasi = "Malatya Kayısı";

            Urun urun3 = new Urun();
            urun3.UrunId = 3;
            urun3.UrunAdi = "Karpuz";
            urun3.UrunFiyati = 10;
            urun3.UrunAciklamasi = "Adana Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2,urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.UrunFiyati);
                Console.WriteLine(urun.UrunAciklamasi);
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
