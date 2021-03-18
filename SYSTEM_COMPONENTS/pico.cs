using System;
using System.Threading;
using x1;

namespace x2
{
    public class pico
    {
        public EventWaitHandle handle;
        public Thread thread;

        public pico(data x)
        {
            handle = new System.Threading.AutoResetEvent(true);
            thread = new System.Threading.Thread(new System.Threading.ThreadStart(x.datacode));
            thread.Start();
        }
    }
}
