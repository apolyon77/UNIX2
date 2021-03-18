using System;
using System.Collections;

// x2 - by Commander Apolyon
// Not for public distribution

namespace x1 { /* the future */ }

namespace x2
{
    public class x2
    {
        public static ArrayList virtual_space = new ArrayList()
        {
            0.0,             
            //            SYSTEM PROGRAMS                     
            new space(    new system_command()       ),   // 1, "local_system_command",
            new space(    new system_console()       ),   // 2, "local_system_console",
            new space(    new system_journal()       ),   // 3, "local_system_journal",  
            new space(    new system_manager()       ),   // 4, "local_system_manager",
            new space(    new system_messenger()     ),   // 5, "local_system_messenger", 
            new space(    new system_file_manager()  ),   // 6, "local_system_file_manager"
            new space(    new user_console()         ),   // 7, "local_user_console", 
            new space(    new user_journal()         ),   // 8, "local_user_journal",
            new space(    new user_program()         ),   // 9, "local_user_program", 

            //            SYSTEM HARDWARE
            new space(    new keyboard()           ),   // 10: system hardware : keyboard 
        };

        static void Main() {/**/}
    }    
}


