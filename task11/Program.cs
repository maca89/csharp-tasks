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
                int age;

                if (! Int32.TryParse(Console.ReadLine(), out age)) {
                    // Tell them about error.
                    Console.WriteLine("You must provide a number!");
                    continue;
                }

                if (age <= 0) {
                    // Tell them about error.
                    Console.WriteLine("You must be at least 1 year old!");
                    continue;
                }

                return age;
            }
        }

        // Ask for user's cats.
        static int AskForCats()
        {
            while (true) {
                // Tell users what is expected of them.
                Console.Write("Please, write how many cats you have: ");

                // Wait until they write their names.
                int cats;

                if (! Int32.TryParse(Console.ReadLine(), out cats)) {
                    // Tell them about error.
                    Console.WriteLine("You must provide a number!");
                    continue;
                }

                if (cats < 0) {
                    // Tell them about error.
                    Console.WriteLine("You cannot have less than zero cats!");
                    continue;
                }

                return cats;
            }
        }

        // Ask for user's name and age and then prints it.
        static void Main(string[] args)
        {
            // Ask user for the name.
            string name = AskForName();

            // Ask user for the age.
            int age = AskForAge();

            // Ask users how many cats they own.
            int cats = AskForCats();

            // Print their names and ages back.
            Console.WriteLine("Nice to meet you, " + name + ".");
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("You have " + cats + " cats.");
        }
    }
}
