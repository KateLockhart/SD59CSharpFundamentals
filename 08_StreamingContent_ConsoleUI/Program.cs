using _08_StreamingContent_ConsoleUI.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_ConsoleUI
{
    class Program
    {
        // Main method is the entry point that starts the application
        // has one responsiblity to
        static void Main(string[] args)
        {
            // Declare a RealConsole for the "production" app
            var console = new RealConsole();

            // UI Class Instance, a tangible copy of this class
            // now have access to anything in ProgramUI that is made public
            ProgramUI ui = new ProgramUI(console);
            ui.StartRun();
        }
    }
}
