
using System;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            string[] student = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K","L" };
            int[ , ] mark = new int[12,4] { {56,84,68,29}, {94,73,31,89}, {41,63,36,90}, {99,9,18,17}, {62,3,65,75}, {40,96,53,23}, {81,15,27,30}, {21,70,100,22}, {88,50,13,12}, {48,54,52,78}, {64,71,67,25}, {16,93,46,72} };

            for (int i = 0; i < student.Length; i++)
            {
                int sum=0;
                for (int j = 0; j < mark.GetLength(1); j++)
                {
                    sum += mark[i, j];
                }

                Console.WriteLine("The total mark of the {0} is {1} ", student[i], sum);
            }

            int grand_total = 0;

            for (int i = 0; i < mark.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j <mark.GetLength(0); j++)
                {
                    sum += mark[j, i];
                }

                grand_total += sum;
                double average = sum/mark.GetLength(0);
                Console.WriteLine("The Average Mark for subject {0} is {1}",i,average);
            }

                int overall_average = grand_total / mark.Length;

                Console.WriteLine("The overall average of mark is {0}", overall_average);
                Console.ReadLine();
        }
    }
}
