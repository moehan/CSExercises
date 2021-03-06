using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] sale = new int[12];

            for (int i = 0; i < sale.Length; i++)
            {
                Console.Write("Enter Sale for Month {0} : ", i);
                int input_value = Convert.ToInt32(Console.ReadLine());
                sale[i] = input_value;
            }

            for (int i = 0; i < sale.Length-1; i++)
            {
                for (int j = i+1; j < sale.Length; j++)
                {
                    if (sale[j] < sale[i])
                    {
                        int a = sale[j];
                        sale[j] = sale[i];
                        sale[i] = a;
                    }
                }
            }

            Console.WriteLine("Maximum Sale : {0}", sale[11]);
            Console.WriteLine("Minimum Sale : {0}", sale[0]);

            int sum = 0;
            for (int i = 0; i < sale.Length; i++)
            {
                sum += sale[i];
            }
            Console.WriteLine("Average Sale : {0}", sum / 12);
            Console.ReadLine();
        }
    }
}
