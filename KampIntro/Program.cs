using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYaptiMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            
            Console.WriteLine(kategoriEtiketi);



            if (sistemeGirisYaptiMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if(dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişiklik yok butonu");
            }

        }
    }
}
