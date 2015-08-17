using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            String GenderType="" ;

            Console.WriteLine("Enter Your Name");
            String name = Console.ReadLine();

            Console.WriteLine("Now Enter Your Gender. 'M' For Male and 'F' For Female");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 40)
            {
                switch (gender)
                {
                    case 'M':
                        GenderType = "Uncle";break;
                    case 'F':
                        GenderType = "Aunty";break;
                }

            }
            else
            {
                switch (gender)
                {
                    case 'M':
                        GenderType = "Mr."; break;
                    case 'F':
                        GenderType = "Mrs."; break;
                }
            }

            Console.WriteLine("Good Morning {0} {1}", GenderType, name);
            Console.ReadLine();
        }
    }
}