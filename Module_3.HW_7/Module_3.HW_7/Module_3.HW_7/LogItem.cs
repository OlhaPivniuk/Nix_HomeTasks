using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_7
{
    internal class LogItem
    {
        private string message;
        private LogType type;

        public string Message
        {
            get { return message; }
        }

        public LogType Type
        {
            get { return type; }
        }

        public LogItem(string _message, LogType _type)
        {
            message = _message;
            type = _type;
        }
    }
}
