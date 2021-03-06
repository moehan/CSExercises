using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Number");
            int N= Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            double G = random.Next(1, N);

            Console.WriteLine("The Guess Number is {0}", G);

            while (G*G != N && Math.Round(G*G, 5) != N)
            {
                G = (G + N / G) / 2;
            }

            Console.WriteLine("The Square Root of the Number is {0:0.0000}", G);
            Console.ReadLine();
        }
    }
}
