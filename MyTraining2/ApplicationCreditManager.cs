using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining2
{
    class ApplicationCreditManager
    {
        //Method Injection - Burada kredi interface'i ile beraber log servisinide ekliyoruz.
        public void ApplicationCredit(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void PreinformationCredits(List<ICreditManager> creditList)
        {
            foreach (var credits in creditList)
            {
                credits.Calculate();
            }

        }
    }
}
