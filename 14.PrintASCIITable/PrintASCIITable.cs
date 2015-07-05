using System;
using System.Text;

    class PrintASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < 256; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
            }
        }
    }
