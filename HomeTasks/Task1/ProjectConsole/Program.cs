using ProjectConcat;
using System;

namespace ProjectConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();

            // Input: { username} (for console app – as a command line parameter)
            // Output: “Hello, { username}” 

            Console.WriteLine($"Hello, {username}");
            Console.WriteLine($"Hello, " + username);

            // Change the output to following:“{current_time} Hello, {username}!”

            ConcatenationLogic concatenationLogic = new ConcatenationLogic();
            Console.WriteLine(concatenationLogic.Concat(username));
            Console.WriteLine(concatenationLogic.ConcatTypeTwo(username));



        }
    }
}
