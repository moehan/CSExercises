using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] student = new string[] { "Jhon", "Venket", "Mary", "Victor", "Betty" };
            int[] mark = new int[] { 63, 29, 75, 82, 55 };

            for (int i = 0; i < student.Length; i++)
            {
                for (int j = i + 1; j < student.Length; j++)
                {
                    if (student[j].CompareTo(student[i])==-1)
                    {
                        String a = student[j];
                        student[j] = student[i];
                        student[i] = a;
                    }
                }
            }

            Console.WriteLine("The Alphabetically Order of the Students is ...");

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine(student[i]);
            }

           

            for (int i = 0; i < mark.Length; i++)
            {
                for (int j = i + 1; j < mark.Length; j++)
                {
                    if (mark[j]>mark[i])
                    {
                        int a = mark[j];
                        mark[j] = mark[i];
                        mark[i] = a;
                    }
                }
            }

            Console.WriteLine("The Decending Order of the mark is ...");

            for (int i = 0; i < mark.Length; i++)
            {
                Console.WriteLine(mark[i]);
            }

            Console.ReadLine();
        }
    }
}
