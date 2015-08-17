using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A Three Digit Number");
            int number = Convert.ToInt32(Console.ReadLine());

            int HundredDigit = number / 100;
            int TenDigit = (number - (HundredDigit * 100)) / 10;
            int UnitDigit = number - ((HundredDigit * 100) + (TenDigit * 10));

            int Armstrong = Convert.ToInt32(Math.Pow(HundredDigit, 3) + Math.Pow(TenDigit, 3) + Math.Pow(UnitDigit, 3));
            if (number == Armstrong)
            {
                Console.WriteLine("This is an Armstrong Number");
            }
            else
            {
                Console.WriteLine("This is not an Armstrong Number");
            }
           
            Console.ReadLine();
            
        }
    }
}