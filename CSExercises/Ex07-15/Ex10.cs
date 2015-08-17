using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Coordinate no. of x1 ");
            int x1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the Coordinate no. of x2 ");
            int x2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the Coordinate no. of y1 ");
            int y1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the Coordinate no. of y2 ");
            int y2 = Convert.ToInt16(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("The Distance Between Two Coordinates is {0}", distance);

            Console.ReadLine();
        }
    }
}
