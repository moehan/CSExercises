using System;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Number");
            int number = Convert.ToInt32(Console.ReadLine());

            Boolean is_prime = false;

            
            if (number == 2)
            {
                is_prime = true;
            }

            
            
            
            else if (number % 2 == 0)
            {
                is_prime = false;
            }

            
            
            
            
            else
            {
                int remainder=1;
       
                for (int i = 3; i < number; i+=2)
                {
                    remainder = number % i;
                    if (remainder == 0)  break;
                }

                if (remainder == 0)
                {
                    is_prime = false;
                }
                else
                {
                    is_prime = true;
                }
            }
            

            
            
            if (is_prime)
            {
                Console.WriteLine("The Number is a Prime Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The Number is not a Prime Number");
                Console.ReadLine();
            }

            
        }
    }
}
