using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining2
{
    class RevolvingCreditManager : ICreditManager
    {
        //Bu class ile projede hiçbir kod bozulmadan ve başka bir kod eklemeden bu şekilde class ekleyerek sisteme
        //yeni krediler dahil edebildiğimizi denedik.
        public void Calculate()
        {
            Console.WriteLine("Revolving Credit payment plan calculated.");
        }

        public void ViewList()
        {
            throw new NotImplementedException();
        }
    }
}
