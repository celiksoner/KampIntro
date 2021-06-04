using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Customer
    {
        //Eper bir nesne o sınıfa ait değil, gereksiz gibi duruyorsa kesinlikle bir yanlışlık vardır.
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SirketAdi { get; set; }
        public string TcNo { get; set; }
        public string VergiNo { get; set; }

    }
}
