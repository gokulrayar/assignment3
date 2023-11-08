using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using TryParse to convert a string to an integer and then multiply by 5
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                int multipliedResult = result * 5;
                Console.WriteLine($"Converted and multiplied result: {multipliedResult}");
            }
            else
            {
                Console.WriteLine("Conversion to integer failed. Invalid input.");
            }

            // Using Convert to convert a string to DateTime and subtract 1 month
            Console.Write("Enter a date (MM/dd/yyyy): ");
            string dateInput = Console.ReadLine();
            try
            {
                DateTime dateResult = Convert.ToDateTime(dateInput);
                dateResult = dateResult.AddMonths(-1);
                Console.WriteLine($"Converted date with 1 month subtracted: {dateResult:MM/dd/yyyy}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion to DateTime failed. Invalid input.");
            }

            // Using Parse to convert a string to TimeSpan and add 2 hours
            Console.Write("Enter a time (hh:mm:ss): ");
            string timeInput = Console.ReadLine();
            try
            {
                TimeSpan timeResult = TimeSpan.Parse(timeInput);
                timeResult = timeResult.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Converted time with 2 hours added: {timeResult:hh\\:mm\\:ss}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion to TimeSpan failed. Invalid input.");
            }
        }
    }
}

