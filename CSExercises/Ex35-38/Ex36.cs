using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Phrase");
            String phrase = Console.ReadLine();
            String new_phrase = phrase.Replace(" ", "").Replace(".","");
            bool is_palindrome=false;
            char []a = new_phrase.ToArray();

            int i = 0;
            int j = a.Length - 1;
            while(i<j)
            {
                if (a[i].ToString().ToLower() != a[j].ToString().ToLower())
                {
                    is_palindrome = false; break;
                }
                else
                {
                    is_palindrome = true;
                }
                i++;
                j--;
            }

            if (is_palindrome == true)
            {
                Console.WriteLine("This is a Palindrone.");
            }
            else
            {
                Console.WriteLine("This is not a Palindrone");
            }

            Console.ReadLine();
        }
    }
}
