using System;
using System.Threading;
using x1;

// x2 - by Commander Apolyon
// Not for public distribution

namespace x2
{
    public class space
    { 
        public Thread           thread;
        public EventWaitHandle  handle;
                
        public space(program x)
        {
            handle = new System.Threading.AutoResetEvent(true);
            thread = new System.Threading.Thread(new System.Threading.ThreadStart(x.code));            
            thread.Start();           
        }

        ~space()
        {
            Console.WriteLine("> shutting down space");
        }
    }
}
