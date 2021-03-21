using System;
using System.Threading;
using System.Collections;
using x1;
namespace x2
{
    public class particles
    {
        public EventWaitHandle handle;
        public Thread thread;

        public particles(datacode x)
        {
            handle = new AutoResetEvent(true);
            thread = new Thread(x.data);
            thread.Start(this);
        }
    }
}
