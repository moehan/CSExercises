using System.Data.SqlClient;
using System;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(SQT(i));
            }

            Console.ReadLine();
        }

        public static double SQT(int y)
        {
            double a=Math.Sqrt(y);
            return a;
        }
    }
}
