using System;
using System.Threading;
using System.Collections;
using x1;

namespace x2
{
    public class pod
    {
        public EventWaitHandle handle;
        public Thread          thread;        
        public ArrayList       box;

        public pod(cube x)
        {
            box    = new ArrayList();
            handle = new System.Threading.AutoResetEvent(true);
            thread = new System.Threading.Thread(new System.Threading.ThreadStart(x.code));
            thread.Start();
        }
    }
}
