using System;
using System.IO;
using x1;

namespace x2
{
    class command_cube : cube // 
    {
        public void code(object x)
        {
            while (((pod)x).handle.WaitOne())
            {
                switch (((pod)x).message) // check cube message box for command 
                {
                    case "date":      // print the current date and time
                        Console.WriteLine("> " + DateTime.Now.ToString("dddd M/dd/yyyy h:mmtt"));
                        break;

                    case "info":      // powers on the user program
                        string system_directory = Directory.GetCurrentDirectory();
                        string system_root_directory = Directory.GetDirectoryRoot(Directory.GetCurrentDirectory());
                        Console.WriteLine("> System Directory:    " + system_directory);
                        Console.WriteLine("> System Root Dirtory: " + system_root_directory);
                        break;

                    case "clear":     // clears the console
                        Console.Clear();
                        break;

                    case "off":       // unix 2 shutdown sequence
                        System.Environment.Exit(1);
                        break;

                    case "sleep":     // sleeps working thread ~5 seconds
                        System.Threading.Thread.Sleep(5000);
                        Console.WriteLine("> now awake after Sleep(5000)");
                        break;

                    default:
                        Console.WriteLine("> unknown command");
                        break;
                }
            }
        }
    }
}
