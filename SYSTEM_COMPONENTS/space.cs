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
            thread = new Thread(x.code); thread.Start(this);           
        }

        ~space()
        {
            Console.WriteLine("> space closed");
        }
    }
}
