using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        // Naming Convention 
        // Syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler "+ urun.UrunAdi +" sepete eklendi.");
        }

        //Başka ekleme yöntemi
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler " + urunAdi + " sepete eklendi.");
        }

    }
}
