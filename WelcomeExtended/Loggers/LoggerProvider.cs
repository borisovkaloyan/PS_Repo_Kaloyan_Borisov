using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Loggers;

namespace WelcomeExtended.Loggers
{
    public class LoggerProvider : ILoggerProvider
    {
        public LoggerProvider() { }
        public ILogger CreateLogger(string categoryName)
        {
            if(categoryName == "Hello")
            {
                return new HashLogger(categoryName);
            }
            else
            {
                return new FileLogger();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
