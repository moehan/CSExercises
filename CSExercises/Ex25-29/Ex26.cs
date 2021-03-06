using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("No. \t Inverse \t SquareRoot \t SQUARE");
            Console.WriteLine("-----------------------------------------------------------------------------");

            for (int i = 1; i <= 10; i++)
            {
                double inverse = 1.0 / i;
                double sqrt = Math.Sqrt(i);
                double sqr = Math.Pow(i, 2);

                Console.WriteLine("{0} \t {1:0.000} \t\t {2:0.000} \t\t {3:0.0} \t ", i, inverse, sqrt, sqr);
            }
            Console.ReadLine();
        }
    }
}
