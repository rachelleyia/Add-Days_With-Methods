using System;

namespace AddDays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Get user input -- numbers
            Console.Write("Enter a number between 1 to 7: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            string currentDay = GetdayName(dayNumber);

            // Get user input -- add numbers
            Console.Write("Input number to add to the day: ");
            int dayToAdd = Convert.ToInt32(Console.ReadLine());
            string addedDays = AddDays(dayNumber, dayToAdd);
        }

        static string GetdayName(int dayNumber)
        {
            string message = "";

            switch (dayNumber)
            {
                case 1:
                    message = "The day is MONDAY";
                    Console.WriteLine(message);
                    break;
                case 2:
                    message = "The day is TUESDAY";
                    Console.WriteLine(message);
                    break;
                case 3:
                    message = "The day is WEDNESDAY";
                    Console.WriteLine(message);
                    break;
                case 4:
                    message = "The day is THURSDAY";
                    Console.WriteLine(message);
                    break;
                case 5:
                    message = "The day is FRIDAY";
                    Console.WriteLine(message);
                    break;
                case 6:
                    message = "The day is SATURDAY";
                    Console.WriteLine(message);
                    break;
                case 7:
                    message = "The day is SUNDAY";
                    Console.WriteLine(message);
                    break;
                default:
                    message = "Invalid Input.";
                    Console.WriteLine(message);
                    break;
            }
            return message;
        }

        static string AddDays(int dayNumber, int dayToAdd)
        {
            // Calculate the final day number, wrapping around the week
            int finalDay = (dayNumber + dayToAdd - 1) % 7 + 1;

            string message = "";

            switch (finalDay)
            {
                case 1:
                    message = "The day is MONDAY";
                    Console.WriteLine(message);
                    break;
                case 2:
                    message = "The day is TUESDAY";
                    Console.WriteLine(message);
                    break;
                case 3:
                    message = "The day is WEDNESDAY";
                    Console.WriteLine(message);
                    break;
                case 4:
                    message = "The day is THURSDAY";
                    Console.WriteLine(message);
                    break;
                case 5:
                    message = "The day is FRIDAY";
                    Console.WriteLine(message);
                    break;
                case 6:
                    message = "The day is SATURDAY";
                    Console.WriteLine(message);
                    break;
                case 7:
                    message = "The day is SUNDAY";
                    Console.WriteLine(message);
                    break;
                default:
                    message = "Invalid Input.";
                    Console.WriteLine(message);
                    break;
            }
            return message;
        }
    }
}