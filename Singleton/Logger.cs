using System;

namespace Singleton
{
    public class Logger
    {
        private static Logger _logger;

        private Logger(){}

        public static Logger GetLogger()
        {
            if(_logger==null)
            {
                _logger = new Logger();
            }
            return _logger;
        }
        public void Log(string msg) => Console.WriteLine($"{DateTime.Now} {msg}");
        private string fmt;
        public void ChangeFormat(string fmt)
        {
            this.fmt = fmt;
        }
        public override string ToString()
        {
            return fmt;
        }
    }
}
