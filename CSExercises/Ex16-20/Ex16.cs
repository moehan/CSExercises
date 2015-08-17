using System;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter Your Name");
            String name = Console.ReadLine();
            Console.WriteLine("Now Enter Your Gender. 'M' For Male and 'F' For Female");
            char gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M')
            {
                Console.WriteLine("Good Morning Mr. {0}", name);
            }
            else if (gender == 'F')
            {
                Console.WriteLine("Goodmorning Ms. {0}", name);
            }
            else
            {
                Console.WriteLine("Input Only 'M' or 'F' for gender ");
            }

            Console.ReadLine();
        }
    }
}