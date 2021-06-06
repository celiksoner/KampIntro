using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining2
{
    class FileLogService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Added log to in file.");
        }
    }
}
