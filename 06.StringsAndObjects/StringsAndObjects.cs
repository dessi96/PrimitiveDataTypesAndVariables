using System;

    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object variable = hello + " " + world;
            string sentence = (string)variable;

            Console.WriteLine(sentence);

        }
    }

