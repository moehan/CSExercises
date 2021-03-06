using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A Word Or A set of Words : ");
            string word = Console.ReadLine();
            char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };

            char[] c = word.ToArray();
            int count = 0, a_count=0, e_count=0, i_count=0, o_count=0, u_count=0;
             
            for (int i = 0; i < c.Length; i++)
            {
                for(int j=0;j<vowel.Length;j++)
                {
                    if (c[i].ToString().ToLower() == vowel[j].ToString())
                    {
                        count++;

                        switch (c[i].ToString().ToLower())
                        {
                            case "a": a_count++; break;
                            case "e": e_count++; break;
                            case "i": i_count++; break;
                            case "o": o_count++; break;
                            case "u": u_count++; break;
                        }

                            
                    }
                }
                
            }

            Console.WriteLine("The Number of Vowels in \"{0}\" is {1}", word, count);
            Console.WriteLine("The Number of \"a\" is {0}",a_count );
            Console.WriteLine("The Number of \"e\" is {0}",e_count);
            Console.WriteLine("The Number of \"i\" is {0}",i_count );
            Console.WriteLine("The Number of \"o\" is {0}",o_count );
            Console.WriteLine("The Number of \"u\" is {0}",u_count );
            Console.ReadLine();
        }
    }
}
