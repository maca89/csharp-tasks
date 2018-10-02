using System;

namespace task05
{
    class Program
    {
        // Ask for user's name and returns it.
        static string AskForName()
        {
            while (true) {
                // Tell users what is expected of them.
                Console.Write("Please, write your name: ");

                // Wait until they write their names.
                string name = Console.ReadLine();

                if (name != "") {
                    // We've got the name!
                    return name;
                }

                // Tell them about error.
                Console.WriteLine("You didn't write any name.");
            }
        }

        // Ask for user's age and returns it.
        static int AskForAge()
        {
            while (true) {
                // Tell users what is expected of them.
                Console.Write("Please, write your age: ");

                // Wait until they write their names.
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0) {
                    // Tell them about error.
                    Console.WriteLine("You must be at least 1 year old!");
                    continue;
                }

                return age;
            }
        }

        // Ask for user's name and age and then prints it.
        static void Main(string[] args)
        {
            // Ask user for the name.
            string name = AskForName();

            // Ask user for the age.
            int age = AskForAge();

            // Print their names and ages back.
            Console.WriteLine("Nice to meet you, " + name + ". You are " + age + " years old.");
        }
    }
}
