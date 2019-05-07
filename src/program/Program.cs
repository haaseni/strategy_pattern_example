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
            var aVal = Console.ReadLine();

            Console.WriteLine("Math Operation? (+,-,/,*):");
            var strategy = Console.ReadLine();

            Console.WriteLine("Second Number:");
            var bVal = Console.ReadLine();

            if (int.TryParse(aVal, out var aNum) && int.TryParse(bVal, out var bNum))
            {
                IMathOperator selectedStrategy = strategies[strategy];

                var result = Calculate(aNum, bNum, selectedStrategy);

                Console.WriteLine($"Result: {result}\n");
            }
            
            Console.WriteLine("Would you like to conduct another math operation? (y/n):");
            var runAgain = Console.ReadLine();

            if (runAgain?.ToLower() == "y")
                QueryUser();
        }

        static int Calculate(int a, int b, IMathOperator op)
        {
            return op.Calculate(a, b);
        }
    }
}
