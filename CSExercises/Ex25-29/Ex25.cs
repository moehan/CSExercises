
using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int product = 1;

            Console.Write("{0}! =", num);
            for (int i = 1; i <= num; i++)
            {
                if (num - (i - 1) == 1)
                {
                    Console.Write(num - (i - 1)); break;
                }
                Console.Write(num - (i - 1) + " x");

                product *= num - (i - 1);
            }
            Console.Write(" = " + product);

            Console.WriteLine(" ");


            int new_product = 1;
            Console.Write("{0}! =", num);
            for (int i = num; i > 0; i--)
            {
                if (i == 1)
                {
                    Console.Write(i); break;
                } 
                Console.Write(i + " x");
                new_product *= i;
            }
            Console.Write(" =" + new_product);
            Console.ReadLine();
        }
    }
}
