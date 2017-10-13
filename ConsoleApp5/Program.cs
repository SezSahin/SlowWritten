using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SlowWritten
{
    class Program
    {
        static void Main()
        {
            //
            // 1. Type "Console" and press "."
            // 2. Select "BackgroundColor".
            // 3. Press space and "=", then press tab.
            //
            //Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("White on blue.");
            //Console.WriteLine("Another line."); // <-- This line is still white on blue.
            string sezer = "How is your day going so far?   \n \n";
            foreach (char c in sezer)
            {
                Console.Write(c);
                Thread.Sleep(70);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            string Yo = "Anything interesting?   \n";
            foreach (char c in Yo)
            {
                Console.Write(c);
                Thread.Sleep(70);
            }
            Console.ResetColor();
        }
    }
}
