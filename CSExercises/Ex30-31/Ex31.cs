using System;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <=1000; i++)
            {
                int sum = 0;
                for (int a = 1; a < i; a++)
                {
                    int x = i % a;
                    if (x == 0)
                    {
                        sum += a;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
