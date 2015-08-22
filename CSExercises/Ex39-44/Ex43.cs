using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Hex(i));
            }
            Console.ReadLine();
        }

        public static string Hex(int i)
        {
            string []hex=new string[2];
            int a = i,count=0;
            string h = "";
            
            do
            {

                hex[count] = (a % 16).ToString();

                switch (a % 16)
                {
                    case 10: hex[count] = "A"; break;
                    case 11: hex[count] = "B"; break;
                    case 12: hex[count] = "C"; break;
                    case 13: hex[count] = "D"; break;
                    case 14: hex[count] = "E"; break;
                    case 15: hex[count] = "F"; break;
                }

                a = a / 16;
                count++;
            } while (a / 16 != 0);

            // now converting the Strig "h" inversely to get the hexadecimal value

            //string hexadecimal = "";

            //for (int b = h.Length; b >= 0; b--)
            //{
            //    hexadecimal += h[b];
            //}

            return h;

        }
        
    }
}
