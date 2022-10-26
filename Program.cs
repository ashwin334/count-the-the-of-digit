using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_the_the_of_digit
{
    internal class palindrome_number
    {
        static void Main(string[] args)
        {
            int num, R, sum = 0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            int B = num;
            while (num != 0)

            {
                R = num % 10;
                sum = (sum * 10) + R;
                num = num / 10;

            }
            if (B == sum)
            {
                Console.WriteLine($" palindrome number is:{B}");
            }
            else
            {
                Console.WriteLine($"is not a palindrome number:{B}");
            }

        }

    }
}
