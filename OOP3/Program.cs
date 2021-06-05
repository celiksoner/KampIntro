using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Mortgage,Car,Consumer Manager class'larını yazmak yerine ICreditManager interface'sinide yazabiliriz.
            MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Hesapla();

            CarCreditManager carCreditManager = new CarCreditManager();
            //carCreditManager.Hesapla();

            ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
            //consumerLoanManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationCreditManager applicationCreditManager = new ApplicationCreditManager();
            applicationCreditManager.Application(carCreditManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { carCreditManager, mortgageCreditManager };

            //applicationCreditManager.CreditPreinformation(credits);

        }

    }
}
