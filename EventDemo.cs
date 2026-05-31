using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public delegate void MyEventHandler(string msg);
    public class Publisher
    {
        public event MyEventHandler OnSomething;

        public void DoSomething()
        {
            if (OnSomething != null)
            {
                OnSomething("事件被触发了");
            }
        }
    }
}
