using System;

    class ComparingFloats
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            
            double eps = 0.000001d;
            double absAB = Math.Abs(a - b);
            bool compare = absAB >= eps;
            Console.WriteLine(!compare);
        }
    }

