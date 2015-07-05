using System;

    class JoroTheFootballPlayer
    {
        static void Main()
        {
            string leap = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsHometown = int.Parse(Console.ReadLine());

            int weekendsInYear = 52;
            int normalWeekends = weekendsInYear - weekendsHometown;

            double games = normalWeekends * 2d / 3d + weekendsHometown * 1d + holidays / 2d;

            if (leap == "t")
            {
               games = games + 3;
            }

            Console.WriteLine((int)games);
        }
    }

