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
            Console.WriteLine($"Hello, {username}");
            Console.WriteLine($"Hello, " + username);
            ConcatLogic concatenationLogic = new ConcatLogic();
            Console.WriteLine(concatenationLogic.Concat(username));
            Console.WriteLine(concatenationLogic.ConcatTypeTwo(username));
        }
    }
}
