using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x2
{
    class keyboard : program
    {
        ConsoleKeyInfo[] history_keys       = new ConsoleKeyInfo[10000];
        Char[]           history_characters = new Char[10000];

        public void code()
        {
            // listen to keyboard ALWAYS
            ConsoleKey key_pressed = new ConsoleKey();

            switch (key_pressed)
            {
                // ***** ENTER KEY ***** //
                case ConsoleKey.Enter:
                    // command("date");
                    break;
                // ********************* //

                // ----------------------------------------
                // %%%%%%%%%%%%%%%% LETTERS %%%%%%%%%%%%%%%
                // ----------------------------------------
                case ConsoleKey.A:
                case ConsoleKey.B:
                case ConsoleKey.C:
                case ConsoleKey.D:
                case ConsoleKey.E:
                case ConsoleKey.F:
                case ConsoleKey.G:
                case ConsoleKey.H:
                case ConsoleKey.I:
                case ConsoleKey.J:
                case ConsoleKey.K:
                case ConsoleKey.L:
                case ConsoleKey.M:
                case ConsoleKey.N:
                case ConsoleKey.O:
                case ConsoleKey.P:
                case ConsoleKey.Q:
                case ConsoleKey.R:
                case ConsoleKey.S:
                case ConsoleKey.T:
                case ConsoleKey.U:
                case ConsoleKey.V:
                case ConsoleKey.W:
                case ConsoleKey.X:
                case ConsoleKey.Y:
                case ConsoleKey.Z:

                // ----------------------------------------
                // %%%%%%%%%%%%%%%% NUMBERS %%%%%%%%%%%%%%%
                // ----------------------------------------
                case ConsoleKey.D1:
                case ConsoleKey.D2:
                case ConsoleKey.D3:
                case ConsoleKey.D4:
                case ConsoleKey.D5:
                case ConsoleKey.D6:
                case ConsoleKey.D7:
                case ConsoleKey.D8:
                case ConsoleKey.D9:
                case ConsoleKey.D0:

                // -----------------------------------------------
                // %%%%%%%%%%%%%%%% 10-Key Numbers %%%%%%%%%%%%%%%
                // -----------------------------------------------
                case ConsoleKey.NumPad1:
                case ConsoleKey.NumPad2:
                case ConsoleKey.NumPad3:
                case ConsoleKey.NumPad4:
                case ConsoleKey.NumPad5:
                case ConsoleKey.NumPad6:
                case ConsoleKey.NumPad7:
                case ConsoleKey.NumPad8:
                case ConsoleKey.NumPad9:
                case ConsoleKey.NumPad0:

                // NumPad Functions
                case ConsoleKey.Decimal:
                case ConsoleKey.Add:
                case ConsoleKey.Subtract:
                case ConsoleKey.Multiply:
                case ConsoleKey.Divide:

                // -----------------------------------------------
                // %%%%%%%%%%%%%%%%   MISC.        %%%%%%%%%%%%%%%
                // -----------------------------------------------
                case ConsoleKey.Escape:
                case ConsoleKey.Tab:
                case ConsoleKey.OemComma:
                case ConsoleKey.Spacebar:
                case ConsoleKey.Backspace:

                // CONTROL KEYS
                case ConsoleKey.Insert:
                case ConsoleKey.Delete:
                case ConsoleKey.Home:
                case ConsoleKey.End:
                case ConsoleKey.PageUp:
                case ConsoleKey.PageDown:

                // ARROW KEYS                            
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:

                // -----------------------------------------------
                // %%%%%%%%%%%%%%%% FUNCTION KEYS %%%%%%%%%%%%%%%%
                // -----------------------------------------------

                case ConsoleKey.F1:
                case ConsoleKey.F2:
                case ConsoleKey.F3:
                case ConsoleKey.F4:
                case ConsoleKey.F5:
                case ConsoleKey.F6:
                case ConsoleKey.F7:
                case ConsoleKey.F8:
                case ConsoleKey.F9:
                case ConsoleKey.F10:
                case ConsoleKey.F11:
                case ConsoleKey.F12:
                case ConsoleKey.F13:
                case ConsoleKey.F14:
                case ConsoleKey.F15:
                case ConsoleKey.F16:
                case ConsoleKey.F17:
                case ConsoleKey.F18:
                case ConsoleKey.F19:
                case ConsoleKey.F20:
                case ConsoleKey.F21:
                case ConsoleKey.F22:
                case ConsoleKey.F23:
                case ConsoleKey.F24:
                    break;

                // UNRECOGNIZED KEY - MANDATORY FIX
                default:
                    Console.WriteLine("[unrecognized key]");
                    break;
            }
        }
    }
}
