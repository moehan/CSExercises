using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            long product = 1;
            for (long i = n; i >= 1; i--)
            {
                product *= i;
            }
                return product;
        }

    }
}
