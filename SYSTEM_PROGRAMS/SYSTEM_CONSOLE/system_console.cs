using System;
using System.Collections;
using x1;
namespace x2
{
    public class system_console : program
    {
        public void code()
        {
            circular_loop command_loop  = new circular_loop(5);                         
            ArrayList     command_cubes = new ArrayList()
            {
                new pod(    new command_cube()      ),
                new pod(    new command_cube()      ),
                new pod(    new command_cube()      ),
                new pod(    new command_cube()      ),
                new pod(    new command_cube()      ),
            };

            while (command_loop.enabled) 
            {
                ((pod)command_cubes[command_loop.next()]).SendMessage(Console.ReadLine());
            }
        }
    }

}
