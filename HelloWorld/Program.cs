// A Hello World! program in C#
using System; // Allows me to directly use the System classes and methods without fully qualifying them.
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            System.Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode. 
            // This time, omitting System. because I already declared "using System"
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

// "That's one small step for man. One giant leap for mankind." - Neil Armstrong