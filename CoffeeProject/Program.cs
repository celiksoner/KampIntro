using CoffeeProject.Abstract;
using CoffeeProject.Concrete;
using System;

namespace CoffeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Kahve dükkanları için müşteri yönetimi yapan bir sistem yazacağız.
             Starbucks ve Nero firması için çalışıyoruz. İki firma da müşterilerini veri tabanına kaydetmek istiyor.
             Starbucks müşterileri kaydederken, mutlaka mernis doğrulaması istiyor. Nero müşterileri kaydederken böyle bir şey istemiyor.
             Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.
             */

            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { Id = 1, FirstName = "Soner", LastName = "Celik", NationalityId = "1234567890", DateOfBirth = new DateTime(11994,10,22)});




        }
    }
}
