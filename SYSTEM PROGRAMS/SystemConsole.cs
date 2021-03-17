using System;
using System.Collections;
using System.Threading;
using System.IO;
using System.Text;
using x1;

// x2 - by Commander Apolyon
// Not for public distribution

namespace x2
{
    public class SystemConsole : program
    {
        void command(string command)
        {
            switch (command)
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

                case "off":       // exit the system
                    System.Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("> unknown command");
                    break;
            }
        }

        public void code()
        {
            while (true)
            {
                command(Console.ReadLine());
            }
        }
    }
}
