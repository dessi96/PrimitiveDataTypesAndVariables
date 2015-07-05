using System;

    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before:\n" + a);
            Console.WriteLine(b);

            int a2 = a;
            a = b;
            b = a2;

            Console.WriteLine("After:\n" + a);
            Console.WriteLine(b);
        }
    }
