using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationCreditManager
    {
        public void Application(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Hesapla();
            loggerService.Log();
        }

        public void CreditPreinformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
    }
}
