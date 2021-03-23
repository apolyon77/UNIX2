using System;
using System.Threading;
using x1;
namespace x2
{
    public class pico
    {
        public Thread          thread;
        public EventWaitHandle handle;

        public pico(qbit x)
        {
            handle = new AutoResetEvent(true);
            thread = new Thread(x.code); thread.Start(this);
        }

        ~pico()
        {
            Console.WriteLine("pico offline");
        }
    }
}
