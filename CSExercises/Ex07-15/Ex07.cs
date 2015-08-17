using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter your salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());
            double increment = (salary * 0.1) + (salary * 0.03);
            double total = salary + increment;
            Console.WriteLine("The Total Salary is {0:C}", total);
            Console.ReadLine();
        }
    }
}
