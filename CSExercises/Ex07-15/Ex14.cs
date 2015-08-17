using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the lendth of side1 of the Triangle ");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the lendth of side2 of the Triangle ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the lendth of side3 of the Triangle ");
            int c = Convert.ToInt16(Console.ReadLine());

            int s = a + b + c;

            double Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("The length cannot be zero or a negative number. Please Try again");
            }
            else
            {
                Console.WriteLine("The Area of the Triangle is {0} ", Area);
            }

            Console.ReadLine();
        }
    }
}