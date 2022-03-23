using System;

namespace Singleton
{
    public class Logger
    {
        private Logger(){}


        private static Logger _logger;
        public static Logger GetLogger()
        {
            if(_logger==null)
            {
                _logger = new Logger();
            }
            return _logger;
        }
        public void Log(string msg) => Console.WriteLine($"{DateTime.Now} {msg}");
    }
}
