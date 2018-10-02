using System;

namespace task03
{
    class Program
    {
        // Ask for user's name and then prints it.
        static void Main(string[] args)
        {
            // Tell users what is expected of them.
            Console.Write("Please, write your name: ");

            // Wait until they write their names.
            string name = Console.ReadLine();

            // Print their names back.
            Console.WriteLine("Nice to meet you, " + name + ".");
        }
    }
}
