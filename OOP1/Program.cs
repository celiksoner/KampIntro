using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 200;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem" };

            ProductManager productManager = new ProductManager();
            
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            /*
            //public int şeklinde sonuç return edilerek daha sonra veri işlenerek kullanılabilir.
            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine("Toplama sonucu: " + toplamaSonucu);

            //Void ile sadece gönderilen verilerek işlenerek sonuç ekrana yazdırılır.
            productManager.Topla2(3, 6);
            */

        }



    }
}
