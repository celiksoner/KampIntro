using System;

namespace MatematikIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(10, 5);
            dortIslem.Cikar(10, 5);
            dortIslem.Carp(10, 5);
            dortIslem.Bol(10, 5);

        }
    }
}
 