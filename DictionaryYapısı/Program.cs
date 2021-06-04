using System;
using System.Collections.Generic;

namespace DictionaryYapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*
            // 1- Dictionary sınıfı içinde sizin belirleyeceğiniz bir key'e uygun olarak
            //değer saklama zorunluluğu vardır.
            //2- Key türünü belirtmek zorunludur.
            //*/

            //Dictionary<string, int> AdYas = new Dictionary<string, int>();
            ////Veri ekleme
            //AdYas.Add("Soner", 26);
            //AdYas.Add("Caner", 32);
            //AdYas.Add("Sakine", 54);
            //AdYas.Add("Alpay", 57);

            //foreach (var okunanDeger in AdYas)
            //{
            //    Console.WriteLine("Okunan değer: "+ okunanDeger);
            //}


            //Kendi Dictionary sınıfımı yazıyorum

            MyDictionary<string, int> AdYas2 = new MyDictionary<string, int>();

            Console.WriteLine(AdYas2.Count); 
            AdYas2.Add("Soner", 26);

            Console.WriteLine(AdYas2.Count);

            for (int i = 0; i < AdYas2.Count; i++)
            {
                Console.WriteLine("[" + AdYas2.Keys[i] + "]" + "[" +  AdYas2.Values[i] + "]");
            }
        }
    }
}
