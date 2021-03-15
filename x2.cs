using System;
using System.Collections;
using System.Threading;

// x2 - by Commander Apolyon
// Not for public distribution

namespace x1 { /* the future */  }

namespace x2
{
    public class x2
    {
        public static ArrayList virtual_space = new ArrayList()
        {
            0.0, //       SYSTEM PROGRAMS                     
            new space(    new SystemCommand()      ),   // 1, "local_system_command",
            new space(    new SystemConsole()      ),   // 2, "local_system_console",
            new space(    new SystemJournal()      ),   // 3, "local_system_journal",  
            new space(    new SystemManager()      ),   // 4, "local_system_manager",
            new space(    new SystemMessenger()    ),   // 5, "local_system_messenger", 
            new space(    new SystemFileManager()  ),   // 6, "local_system_file_manager"
            new space(    new UserConsole()        ),   // 7, "local_user_console", 
            new space(    new UserJournal()        ),   // 8, "local_user_journal",
            new space(    new UserProgram()        ),   // 9, "local_user_program", 
        };

        static void Main() {/**/}
    }    
}


