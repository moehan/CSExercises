using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("x \t y");
            Console.WriteLine("-------------------");

            for (int x = -5; x <= 5; x++)
            {
                int y =Convert.ToInt32( 2*(Math.Pow(x, 2)) - 4 * x + 3 );
                Console.WriteLine("{0:0.0} \t {1:0.0}", x, y);
            }
            Console.ReadLine();
        }
    }
}
