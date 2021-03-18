using System;
using System.Threading;
using x1;

namespace x2
{
    public class space
    { 
        public Thread           thread;
        public EventWaitHandle  handle;
                
        public space(program x)
        {
            handle = new AutoResetEvent(true);
            thread = new Thread(new ThreadStart(x.code));            
            thread.Start();           
        }

        ~space()
        {
            Console.WriteLine("> shutting down space");
        }
    }
}
