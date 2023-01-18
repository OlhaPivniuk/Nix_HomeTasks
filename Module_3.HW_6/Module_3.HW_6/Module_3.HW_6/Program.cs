using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MessageBox messageBox = new MessageBox();
            var tcs = new TaskCompletionSource();
            messageBox.action += (State state) =>
            {
                Console.WriteLine(state == State.Ok ? "Opened" : "Closed");
                tcs.SetResult();
            };
            messageBox.Open();
            tcs.Task.GetAwaiter().GetResult();
        }
    }
}
