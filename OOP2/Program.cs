using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri
            //Soner Çelik 
            Individual individual1 = new Individual();
            individual1.Id = 1;
            individual1.MusteriNo = "1";
            individual1.Adi = "Soner";
            individual1.Soyadi = "Çelik";

            //Tüzel Müşteri
            //Samsung
            Corporate corporate2 = new Corporate();
            corporate2.Id = 2;
            corporate2.MusteriNo = "2";
            corporate2.SirketAdi = "Samsung";
            corporate2.VergiNo = "123456";

            // SOLID

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individual1);
            customerManager.Add(corporate2);
        }
    }
}
