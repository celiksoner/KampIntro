using System;
using System.Collections.Generic;

namespace MyTraining2
{
    class Program
    {
        static void Main(string[] args)
        {
            //LoggerService interface oluşturarak database ve file log'u için iki ayrı class oluşturarak loggerservice'i implement ettik.
            //Database log'unu çağırdık.
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            //databaseloggerService.Log();

            //Interface'ler new'lenemez.

            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            //creditManager.Calculate();

            ICreditManager carCreditManager = new CarCreditManager();
            

            ApplicationCreditManager applicationCreditManager = new ApplicationCreditManager();
            applicationCreditManager.ApplicationCredit(carCreditManager,databaseLoggerService);

            List<ICreditManager> creditList = new List<ICreditManager>() {new RevolvingCreditManager(),mortgageCreditManager };

            applicationCreditManager.PreinformationCredits(creditList);
            
        }
    }
}
