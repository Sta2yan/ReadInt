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

            number = GetNumberFromString();

            Console.WriteLine($"Ваше число: {number}");
        }

        static int GetNumberFromString()
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