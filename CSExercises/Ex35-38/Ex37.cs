using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Phrase");
            String phrase = Console.ReadLine();

            string[] words = phrase.Split();

            for (int i = 0; i < words.Length; i++)
            {
                char[] a = words[i].ToArray();
                String output;
                
                for (int j = 0; j < a.Length; j++)
                {
                    if (j == 0)
                    {
                        output = a[j].ToString().ToUpper();
                    }
                    else
                    {
                        output = a[j].ToString().ToLower();
                    }
                    Console.Write(output);
                }
                Console.Write(" ");
            }

            Console.ReadLine();
        }
    }
}
