using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int num;
            int count = 0;

            Random r = new Random();
            int lucky_number = r.Next(1, 11);

            do
            {
                Console.WriteLine("Enter A Number");
                num = Convert.ToInt32(Console.ReadLine());
                count++;
                if (num != lucky_number)
                {
                    Console.WriteLine("Try Again");
                }

            } while (num != lucky_number);

            if (count <= 2)
            {
                Console.WriteLine("You Are A Wizard !");
            }
            else if (count > 2 && count <= 5)
            {
                Console.WriteLine("You Are A Good Guess !");
            }
            else
            {
                Console.WriteLine("You Are Lousy !");
            }

            Console.ReadLine();
        }
    }
}
