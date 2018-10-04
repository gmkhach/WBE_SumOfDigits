/*
 * Write a method that takes a number and returns the sum of all of its integers.
 */ 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter a positive integer\n\n>>> ");
                    int number = int.Parse(Console.ReadLine().Trim());
                    if (number > 0 && number % 1 == 0)
                    {
                        Console.WriteLine($"\nSum of digits: {SumOfDigits(number)}");
                    }
                    else
                    {
                        Console.Clear();
                        throw new Exception("Invalid Entry!");
                    }
                    Console.Write("\nPress Enter to try a different number...");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }

            } while (true);
        }

        static int SumOfDigits(int number)
        {
            return number != 0?  number % 10 + SumOfDigits(number / 10) : number;
        }
    }
}