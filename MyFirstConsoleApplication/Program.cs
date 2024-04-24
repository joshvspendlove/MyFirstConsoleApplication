using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        String name = "Josh Spendlove"; 
        String location = "Lehi, UT";

        public void printName()
        {
            Console.WriteLine("My name is " + name);
        }

        public void printLocation() 
        {
            Console.WriteLine("I am from " + location);
        }

        public void printTodaysDate()
        {
            Console.WriteLine("Today is: " + getDate(null).ToShortDateString());
        }

        private int getDaysTilChristmas()
        {
            DateTime today = getDate(null);
            DateTime christmas = getDate("12/25/" + today.Year);
            int daysTilChristmas;
            if (today > christmas)
            {
                christmas = DateTime.Parse("12/25/" + (today.Year + 1));
            }
            daysTilChristmas = (christmas - today).Days;
            return daysTilChristmas;

        }

        public void printDaysTilChristmas()
        {
            int daysTilChristmas = getDaysTilChristmas();
            Console.WriteLine("There are " + daysTilChristmas + " day(s) until Christmas.");
        }

        private DateTime getDate(String date)
        {
            if (date == null)
            {
                return DateTime.Now;
            }
            else
            {
                return DateTime.Parse(date);
            }
        }

        public void runGlazerCalc()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter the length in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the width in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("=====================================");
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Program program = new Program();
            program.printName();    
            program.printLocation();
            program.printTodaysDate();
            program.printDaysTilChristmas();
            Console.WriteLine("-------------------------------------");
            program.runGlazerCalc();
             
        }
    }
}
