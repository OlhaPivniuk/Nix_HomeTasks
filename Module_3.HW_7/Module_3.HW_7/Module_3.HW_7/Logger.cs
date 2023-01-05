using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_7
{
    internal class Logger
    {
        readonly List<LogItem> activeLogItems = new ();
        private int index = 0;        

        private static Logger? instance;       

        public static Logger GetInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }

        public event Action action;

        public void Log(LogItem item, int N)
        {
            activeLogItems.Add(item);
            index++;

            if (index >= N)
            {
                index = 0;
                action?.Invoke();
            }
        }

        public async Task WriteText()
        {
            var text = new StringBuilder();
            for (int i = 0; i < activeLogItems.Count; i++)
            {
                var item = activeLogItems[i];

                text.AppendLine("Type:" + item.Type + "Message:" + item.Message);
            }

            var path = String.Format("Backup\\{0}.txt", DateTime.Now.ToString("yyMMddHHmmssfff"));
            await File.WriteAllTextAsync(path, text.ToString());
            Console.WriteLine($"{text}");
        }
    }
}
