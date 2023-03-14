using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    public class FileLogger : ILogger
    {
        private string _fileName = "errLog.txt";

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            FileStream fs = new FileStream(_fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            var message = formatter(state, exception);

            sw.WriteLine("- LOGGER -");
            sw.WriteLine(message);
            sw.WriteLine("- LOGGER -");

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
