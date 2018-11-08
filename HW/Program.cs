using System;

namespace HW
{
    public class Program
    {
        static void ShowSeason(int monthNumber)
        {
            if (monthNumber >= 3 && monthNumber <= 5)
            {
                Console.WriteLine("Spring");
            }
        }

        public static void Main(string[] args)
        {
            //int monthNumber = 3;
            //ShowSeason(monthNumber);
            //Animal.MakeSound("Gav");

            Console.ReadKey();
        }
    }
}
