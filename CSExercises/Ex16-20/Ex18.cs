using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Mark");
            int mark = Convert.ToInt32(Console.ReadLine());

            String grade = "";

            if (mark <= 100 && mark >= 80)
            {
                grade = "A";
            }
            else if (mark <= 79 && mark >= 60)
            {
                grade = "B";
            }
            else if (mark <= 59 && mark >= 40)
            {
                grade = "C";
            }
            else if (mark < 40 && mark >= 0)
            {
                grade = "F";
            }
            else
            {
                grade = "Error!";
            }

            Console.WriteLine("The Grade : {0}", grade);
            Console.ReadLine();
        }
    }
}