using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    internal class Logger
    {
        private static Logger _instance;
        private List<string> _listLogs = new List<string>();
        private Logger()
        {

        }
        public static Logger GetInstance()
        {
            if (_instance == null)
                _instance = new Logger();
            return _instance;
        }
        public void WriteLog(string message, LogType type)
        {
            string messageText = $"time_log: {DateTime.Now} , type_log: {type} , message: {message}";
            _listLogs.Add(messageText);
            Console.WriteLine(messageText);
        }
        public void Save()
        {
            const string path = "log.txt";

            foreach (string line in _listLogs)
                File.AppendAllText(path, line + "\r\n");
        }
    }
}
