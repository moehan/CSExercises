using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            Console.WriteLine("Sorting Condition ....");
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        int a = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = a;
                    }
                    Console.Write("{0} \t", numbers[i]);
                }
                Console.WriteLine(" \n ");
            }

            Console.WriteLine("After Sorting The Numbers ...");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
