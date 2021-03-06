using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] count_array = new int[10];
            Random random = new Random();

            int [] randon_array=new int[50];

            //to generate the 50 random itegers and generate them into an array
            
            for(int i=0;i<50;i++)
            {
                int randon_number = random.Next(0, 10);
                randon_array[i] = randon_number;
            }

            
            //Assigning the count numbers to an array
            
            for (int j = 0; j < 10; j++)
            {
                int count = 0;
                for (int i = 0; i < randon_array.Length; i++)
                {
                    if (j == randon_array[i])
                    {
                        count++;
                    }
                }
                count_array[j] = count;
            }

            //Printing out the result
            
            Console.WriteLine("Number\tCount");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + "\t" + count_array[i]);
            }

            
            //for part2, showing count numbers as *
            
            Console.WriteLine("Number\tCount");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+"\t");

                for (int j = 0; j < count_array[i]; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.ReadLine();

        }
    }
}
