using System;

namespace GradeBook
{
    class Program
    {
        // A Method Named Main
        // Main has a Parameter called args with type string array
        // array is a collection of objects
        static void Main(string[] args)
        {
            // An If statement to check that the args array is not empty
            if (args.Length > 0) 
            {
                // String Concatonation
                Console.WriteLine("Hello" + args[0] + "!");
                // String Interpulation
                Console.WriteLine($"Hello, {args[0]} !");
            } else {
                Console.WriteLine("Hello");
            }
        }
    }
}
