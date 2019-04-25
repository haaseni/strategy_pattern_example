using System;
using System.Collections.Generic;

namespace strategy_pattern_example
{
    class Program
    {
        private static Dictionary<string, IMathOperator> strategies = new Dictionary<string, IMathOperator>
        {
            { "+", new MathAdd() },
            { "-", new MathSubtract() },
            { "/", new MathDivide() },
            { "*", new MathMultiply() }
        };

        static void Main(string[] args)
        {
            QueryUser();
            Console.ReadKey();
        }

        static void QueryUser()
        {
            Console.WriteLine("\nFirst Number:");
            var num1 = Console.ReadLine();

            Console.WriteLine("Math Operation? (+,-,/,*):");
            var strategy = Console.ReadLine();

            Console.WriteLine("Second Number:");
            var num2 = Console.ReadLine();

            IMathOperator selectedStrategy = strategies[strategy];
            int result = selectedStrategy.Operation(Convert.ToInt32(num1), Convert.ToInt32(num2));
            Console.WriteLine($"Result: {result}\n");
            
            Console.WriteLine("Would you like to conduct another math operation? (y/n):");
            var runAgain = Console.ReadLine();

            if (runAgain?.ToLower() == "y")
                QueryUser();
        }
    }
}
