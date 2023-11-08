using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment_3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // using tryparse
            string numberString = "123";
            int number;
            if (int.TryParse(numberString,out number))
            {
                Console.WriteLine("conversion successful. Converted vlue:" + number);
            }
            else
            {
                Console.WriteLine("conversion faiked.Invalid input.");
            }
            //using convert
            string numberString = "3.14";
            double number;

            try
            {
                number = Convert.ToDouble(numberString);
                Console.WriteLine("Conversion successful. Converted value: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Conversion failed. Input value is too large or too small.");
            }
            */

            //using parse

            string numberString = "3.12334";
            decimal number;

            try
            {
                number = decimal.Parse(numberString);
                Console.WriteLine("Conversion successful. Converted value: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Conversion failed. Input value is too large or too small.");
            }
        }
    }
}
