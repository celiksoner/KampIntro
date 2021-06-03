using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>
    {
        //Tüm metodlardan ulaşılabilir bir array oluşturuyoruz.
        T[] items;
        
        //Class her çağırıldığında costructor metoduyla yeni bir array oluşturuyoruz.
        public MyList()
        {
            items = new T[0];
        }


        //Burada ekleme metodu çağırıldığında referans adresi değişeceği için önce mevcut dizimizin elemanlarını geçici bir diziye aktarıyoruz daha sonra
        //Mevcut dizinin eleman sayısını bir arttırarak geçici diziden verileri geri alıyoruz. Bu işlemden sonra yeni gelen veriyi dizimizin son index'ine ekliyoruz.
        //
        public void Add(T item)
        {
            //Elimizdeki verileri geçici diziye aktarma komutu
            T[] tempArray = items;
            //Mevcut dizimizin boyutunu 1 arttırıyoruz.
            items = new T[items.Length + 1];

            //Döngü yardımı ile tempArray dizisinin boyutu kadar döngü ile verilerimizi mevcut dizimize çekiyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //Burada son olarak add metodundan gelen veriyi dizimizin son index'ine ekliyoruz.
            items[items.Length - 1] = item;
            
        }

        public int Length
        {
            get { return items.Length; }
        }
        
        public T[] Items
        {
            get { return items; }
        }

       
    }
}
