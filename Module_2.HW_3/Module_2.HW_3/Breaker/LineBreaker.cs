using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_3.Breaker
{
    public class LineBreaker
    {
        static public string[] ReturnWordArr(char symbol, string str, short index)
        {
            return str.Split(new char[] { symbol }, StringSplitOptions.RemoveEmptyEntries).Skip(index).ToArray();
        }
    }
}
