using System;
using System.Collections;
using x1;
namespace x2
{
    public class system_console : program
    {
        public void code()
        {
            CircularLoop command_loop  = new CircularLoop(5);                         
            ArrayList    command_cubes = new ArrayList()  // command fulfillment
            {
                new pod(    new console_command()      ),
                new pod(    new console_command()      ),
                new pod(    new console_command()      ),
                new pod(    new console_command()      ),
                new pod(    new console_command()      ),
            };

            while (command_loop.enabled) 
            {
                ((pod)command_cubes[command_loop.next()]).SendMessage(Console.ReadLine());
            }
        }
    }

}
