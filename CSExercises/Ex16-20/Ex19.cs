using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance covered in km");
            double km = Convert.ToDouble(Console.ReadLine());

            double distance=Math.Ceiling((km*1000)*10)/10;

            double initial = 2.40;

            double extra = 0.0;
            
            
            if (distance <= 500)
            {
                extra = 0.0;
                
            }
            else if (distance > 500 && distance <= 8500)
            {
                extra = 0.04 * ((distance - 500)/100);
                
            }
            else if (distance > 8500)
            {
                extra = (0.04 * ((distance - 500)/100)) + (0.05 * (distance - 8500)/100);
               
            }

            double total = initial + extra;

            Console.WriteLine("The total Fare is {0}", total);
            Console.ReadLine();
        }
    }
}