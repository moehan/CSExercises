using System;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            for (int i = 5; i < 10000; i++)
            {
                int remainder=0;
                for (int a = 2; a < i; a++)
                {
                    remainder = i % a;
                    if (remainder == 0) break;   
                }
                if(remainder != 0)
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
