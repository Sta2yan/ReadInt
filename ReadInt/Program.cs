using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = ConvertStringToInt();

            Console.WriteLine($"Ваше число: {number}");
        }

        static int ConvertStringToInt()
        {
            int number;
            string userInput;

            do
            {
                Console.WriteLine("Введите число:");
                userInput = Console.ReadLine();
            } while (int.TryParse(userInput, out number) == false);

            return number;
        }
    }
}