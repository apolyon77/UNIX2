using System;
using System.Threading;
using x1;
namespace x2
{
    public class pod
    {
        public EventWaitHandle handle;
        public Thread          thread;        
        public string          message; // temp variable for system_console

        public pod(cube x)
        {
            handle   = new AutoResetEvent(false);
            thread   = new Thread(x.code); thread.Start(this);
        }

        public void SendMessage(string msg) // temp function for system_console
        {
            message = msg;
            this.handle.Set();
        }

        ~pod()
        {
            Console.WriteLine("> pod offline");
        }

    }
}
