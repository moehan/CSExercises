using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            double initial = 2.40;
            Console.WriteLine("Enter the distance covered ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double total = initial + (distance * 0.4);
            Console.WriteLine("The total Fare is {0:0.00}", total);
            Console.ReadLine();
        }
    }
}
