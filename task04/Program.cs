using System;

namespace task04
{
    class Program
    {
        // Ask for user's name and then prints it.
        // Enhanced with user error detection.
        static void Main(string[] args)
        {
            // Tell users what is expected of them.
            Console.Write("Please, write your name and press ENTER: ");

            // Wait until they write their names.
            string name = Console.ReadLine();

            if (name == "") {
                // No name provided, print error.
                Console.WriteLine("You didn't write any name.");
            }
            else {
                // Print their names back.
                Console.WriteLine("Nice to meet you, " + name + ".");
            }
        }
    }
}
