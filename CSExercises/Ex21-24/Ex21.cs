using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int Lucky_no = 88;
            int a;
            do
            {
                Console.WriteLine("Enter A Number");
                a = Convert.ToInt32(Console.ReadLine());

            } while (Lucky_no != a);

            Console.WriteLine("Lucky You ... ");
        }
    }
}
