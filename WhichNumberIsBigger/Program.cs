using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichNumberIsBigger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Please Enter The Firs Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter The Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("First Number is Bigger");
            }
            else if (number2 == number1)
            {
                Console.WriteLine("The Two Numbers Are Equal");
            }
            else
            {
                Console.WriteLine("Second Number is Bigger");
            }
            Console.ReadKey();
        }
    }
}
