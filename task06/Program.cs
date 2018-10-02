using System;

namespace task05
{
    class Program
    {
        // Ask for user's name and returns it.
        static string AskForName()
        {
            // Tell users what is expected of them.
            Console.Write("Please, write your name: ");

            // Wait until they write their names.
            return Console.ReadLine();
        }

        // Ask for user's name and then prints it.
        // Uses a simple function to ensure a name was given.
        static void Main(string[] args)
        {
            // Ask user for the name.
            string name = "";

            while (name == "") {
                name = AskForName();

                if (name == "") {
                    Console.WriteLine("You didn't write any name.");
                }
            }

            // Print their names back.
            Console.WriteLine("Nice to meet you, " + name + ".");
        }
    }
}
