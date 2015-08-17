using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity for TV : ");
            int TV = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter quantity for TV : ");
            int DVD = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter quantity for TV : ");
            int MP3 = Convert.ToInt32(Console.ReadLine());

            double TVPrice = TV * 900;
            double DVDPrice = DVD * 500;
            double MP3Price = MP3 * 700;

            double amount_to_be_discounted=TVPrice+DVDPrice;
            double discount=0.0;

            double total = TVPrice + DVDPrice + MP3Price;
           

            if (total > 5000 && total<=1000)
            {
                discount = amount_to_be_discounted * 0.1;
            }
            else if (total > 1000)
            {
                discount = amount_to_be_discounted * 0.15;
            }

            double actual_price = total - discount;

            Console.WriteLine("Number of TVs : {0}", TV);
            Console.WriteLine("Number of DVDs : {0}", DVD);
            Console.WriteLine("Number of MP3s : {0}", MP3);
            Console.WriteLine("The Discount Amount : {0}", discount);
            Console.WriteLine("The Total Price : {0}", actual_price);
            Console.WriteLine("Thank You!");

            Console.ReadLine();
        }
    }
}