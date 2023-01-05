using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_6
{
    public class MessageBox
    {
        public event Action<State> action;
        public async void Open()
        {
            Console.WriteLine("Window is opened");
            await Task.Delay(3000);
            Console.WriteLine("Window is closed");
            var random = new Random();
            var state = random.Next(0, 1) == 0 ? State.Ok : State.Cancel;
            action?.Invoke(state);
        }
    }
}
