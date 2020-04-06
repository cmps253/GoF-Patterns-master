using System;

namespace SingletonLogger
{
    public class Logger
    {
        private Logger() { }

        private string fmt = "dd/mm/yy hh:mm";

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
        public void ChangeLogformat(string fmt)
        {
            this.fmt = fmt;
        }
        public override string ToString() => fmt;
    }
}