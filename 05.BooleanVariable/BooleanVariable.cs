﻿using System;

class BooleanVariable
    {
        static void Main()
        {
            bool isFemale = false;
            Console.WriteLine("Are you a female? (Yes or No)");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                isFemale = true;
                Console.WriteLine(isFemale);
            }
            else if(answer == "No")
            {
                isFemale = false;
                Console.WriteLine(isFemale);
            }
            else
            {
                Console.WriteLine("Please answer with \"Yes\" or \"No\"");
            }
            
        }
    }

