using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_the_the_of_digit
{
    internal class Reverse_numbers
    {
        static void Main(string[] args)
        {
                int num, R, sum = 0;
                Console.WriteLine("enter the number");
                num=Convert.ToInt32(Console.ReadLine());
                while (num > 0)
                {
                    R = num % 10;
                    sum =sum*10+R;
                    num = num / 10;
                    {
                        Console.WriteLine("reverse number is " + sum);

                    }
                }
            }
    }
}
