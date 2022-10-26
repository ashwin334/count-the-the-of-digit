using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_the_the_of_digit
{
    internal class sum_of_all_digit_of_number
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Enter multiple digit number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;


                //Console.WriteLine("summation of digit in given number"+sum);




            }
            Console.WriteLine("summation of digit in given number" + sum);

        }


    }
            
}

