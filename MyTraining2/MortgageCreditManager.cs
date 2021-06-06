using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining2
{
    class MortgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage credit payment plant calculated.");
        }

        public void ViewList()
        {
            throw new NotImplementedException();
        }
    }
}
