using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the First number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Second number");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a * b;

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }

            }

            int HCF = a;

            int LCM = c / HCF;

            Console.WriteLine("The HCF is {0}.", HCF);
            Console.WriteLine("The LCM is {0}.", LCM);
            Console.ReadLine();
        }
    }
}
