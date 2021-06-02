using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        public void Add(Product product)
        {
            product.ProductName = "Kamera";
        }

        public void BiseyYap (int sayi)
        {
            sayi = 99;
        }


    }
}
