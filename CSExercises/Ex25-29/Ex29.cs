using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Number");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                int a = number % i;
                if (a == 0)
                {
                    sum += i;
                }
            }


            if (sum == number)
            {
                Console.WriteLine("The Number is a Perfect Number");
            }
            else
            {
                Console.WriteLine("The Number is not a Perfect Number");
            }
            Console.ReadLine();
        }
    }
}
