using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Loops
    {
        static void Main(string[] args)
        {
            string[] days = { "Sunday", "Monday", "TuesDay", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string day in days)
            {
                Console.WriteLine("The day is : " + day);
            }

            Console.WriteLine("---------------------------------------------------");
            // This is the same as using above
            string[] daysOfWeek = { "Sunday", "Monday", "TuesDay", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine("The day is : " + daysOfWeek[i]);
            }
        }
    }
}
