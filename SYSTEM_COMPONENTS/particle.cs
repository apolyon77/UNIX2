using System;
using System.Threading;
using x1;
namespace x2
{
    public class particle
    {
        public Thread          thread;
        public EventWaitHandle handle;

        // DATACODE - data structures and individual variables
        public particle(datacode x)
        {
            handle = new AutoResetEvent(true);
            thread = new Thread(x.data); thread.Start(this);
        }

        // SYSTEMCODE - system code performing functions, tracking, profiling, unit testing
        public particle(systemcode x)
        {
            handle = new AutoResetEvent(true);
            thread = new Thread(x.system); thread.Start(this);
        }

        // TIMECODE - code for retrieving deciphering sharing calculating and synchronizing time in unix 2
        public particle(timecode x)
        {
            handle = new AutoResetEvent(true);
            thread = new Thread(x.time); thread.Start(this);
        }

        // NETCODE - specific network code for cryptography, synchronicity, connection, routing, firewall, etc
        public particle(netcode x)
        {
            handle = new AutoResetEvent(true);
            thread = new Thread(x.net); thread.Start(this);
        }

        // AUTOCODE - automation code from the unix2 automation library
        public particle(autocode x)
        {
            handle = new AutoResetEvent(true);
            thread = new Thread(x.auto); thread.Start(this);
        }

        ~particle()
        {
            Console.WriteLine("> particle offline");
        }
    }
}
