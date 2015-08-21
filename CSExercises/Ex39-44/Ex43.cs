﻿using System;
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
            string []h = new string [10];
            int count=0;

           while (i/16 >16)
            {
               switch (i % 16)
                {
                    case 10: h[count] = "A"; break;
                    case 11: h[count] = "B"; break;
                    case 12: h[count] = "C"; break;
                    case 13: h[count] = "D"; break;
                    case 14: h[count] = "E"; break;
                    case 15: h[count] = "F"; break;
                }
               
               h[count] = (i % 16).ToString();
               count++;
               i = i / 16;
            }

            String hex = "";
            for (int b = h.Length - 1; b >= 0; b--)
            {
                hex += h[b];
            }

            return hex;
        }
        
    }
}
