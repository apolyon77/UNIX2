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
        public ArrayList       databox;
        public string          message;

        public pod(cube x)
        {
            databox  = new ArrayList();
            handle   = new AutoResetEvent(false);
            thread   = new Thread(x.code);
            thread.Start(this);
        }

        public void SendMessage(string msg)
        {
            message = msg;
            this.handle.Set();
        }
    }
}
