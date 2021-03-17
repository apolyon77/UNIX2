using System;
using System.Threading;
using x1;

namespace x2
{
    public class pod
    {
        public Thread thread;
        public EventWaitHandle handle;

        public pod(cube x)
        {
            handle = new System.Threading.AutoResetEvent(true);
            thread = new System.Threading.Thread(new System.Threading.ThreadStart(x.code));
            thread.Start();
        }
    }
}
