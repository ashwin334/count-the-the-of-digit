using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_the_the_of_digit
{
    internal class swap_two_number_with_third_number
    {
        static void Main( string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter first number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            {
                Console.WriteLine($"before swaping first number(num1) & second number(num2)");
                num3 = num1;
                num1 = num2;
                num2 = num3;
                Console.WriteLine($"before swaping first number{num1}& second number{num2}");
            }
            Console.ReadLine();
            
        }
    }
}
