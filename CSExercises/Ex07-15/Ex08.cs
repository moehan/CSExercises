using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter Temperature in Celceius Scale : ");
            int C = Convert.ToInt16(Console.ReadLine());
            double F=1.8*C+32;
            Console.WriteLine("The Temperature on Farenheit Scale is {0}", F);
            Console.ReadLine();
        }
    }
}
