using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The amount of currency ");
            double input = Convert.ToDouble(Console.ReadLine());

            int a = Convert.ToInt32(input * 100);

            int[] cent = new int[] { 100, 50, 20, 10, 5 };


            for (int j = 0; j < cent.Length; j++)
            {
                
                    while (a >= cent[j])
                    {
                        a = a - cent[j];
                        Console.WriteLine(cent[j] + "c");
                    }
                
            }

            Console.ReadLine();
                
        }
    }
}
