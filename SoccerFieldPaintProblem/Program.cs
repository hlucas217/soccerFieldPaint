using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerFieldPaintProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // You are helping with a local soccer league
            // They need to be able to paint their fields to mark the center circle. 
            // Different leagues have different sized circles, however.
            // Make a program that will ask for the size of the circle and then tell them how much paint they
            // need to cover the center circle. The paint they use covers about 100 sq ft per bucket.
            // Make sure they have enough paint, it's ok if there is some extra left in the last bucket.
            // Show the output like this:
            // It will take 8 buckets to paint the 15' radius circle
            // Bonus: Different colors cover better than others. 
            // Let the user pick the color and show the result. 
            // The colors are as follows:
            // Red = 100 sq ft/bucket
            // Blue = 120 sq ft/bucket
            // Green = 90 sq ft/bucket
            // Yellow = 70 sq ft/bucket
            // Extra Bonus: The colors also cost different amounts. Tell the user how much it will cost to paint the field.
            // amounts. Tell the user how much it will cost
            // Red = 25$ / bucket
            // Blue = 28$ / bucket
            // Green = 33$ / bucket
            // Yellow = 22$ / bucket
            
            Console.WriteLine("What is the diameter of the circle you need to paint?");
            string diameter = Console.ReadLine();
            int diameterInt = Convert.ToInt32(diameter);
            decimal area = (3.14m * ((diameterInt / 2) * (diameterInt / 2)));
            decimal buckets = (area / 100);
            int bucketsInt = Convert.ToInt32(buckets);
            Console.WriteLine("What color paint would you like to use? red, green, blue or yellow?");
            string color = Console.ReadLine().ToLower();
            int price;

            if (color == "red")
            {
                price = 25;
                Console.WriteLine("Your paint will cost $25 per bucket.");
                
                if (area % 100 != 0 || area < 100)
                {
                    bucketsInt += 1;
                    int cost = (bucketsInt * price);
                    Console.WriteLine("You will need " + bucketsInt + " bucket(s) of " + color + " paint to paint your " + diameterInt + " foot diameter circle.");
                    Console.WriteLine("");
                    Console.WriteLine("It will cost you a total of " + cost + " dollar(s) to buy your  red paint.");
                }
            }

            if (color == "blue")
            {
                price = 28;
                Console.WriteLine("Your paint will cost $28 per bucket.");

                if (area % 100 != 0 || area < 120)
                {
                    bucketsInt += 1;
                    int cost = (bucketsInt * price);
                    Console.WriteLine("You will need " + bucketsInt + " bucket(s) of " + color + " paint to paint your " + diameterInt + " foot diameter circle.");
                    Console.WriteLine("");
                    Console.WriteLine("It will cost you a total of " + cost + " dollar(s) to buy your blue paint.");
                }
            }

            if (color == "green")
            {
                price = 33;
                Console.WriteLine("Your paint will cost $33 per bucket.");

                if (area % 100 != 0 || area < 90)
                {
                    bucketsInt += 1;
                    int cost = (bucketsInt * price);
                    Console.WriteLine("You will need " + bucketsInt + " bucket(s) of " + color + " paint to paint your " + diameterInt + " foot diameter circle.");
                    Console.WriteLine("");
                    Console.WriteLine("It will cost you a total of " + cost + " dollar(s) to buy your green paint.");
                }
            }

            if (color == "yellow")
            {
                price = 22;
                Console.WriteLine("Your paint will cost $22 per bucket.");

                if (area % 100 != 0 || area < 70)
                {
                    bucketsInt += 1;
                    int cost = (bucketsInt * price);
                    Console.WriteLine("You will need " + bucketsInt + " bucket(s) of " + color + " paint to paint your " + diameterInt + " foot diameter circle.");
                    Console.WriteLine("");
                    Console.WriteLine("It will cost you a total of " + cost + " dollar(s) to buy your yellow paint.");
                }
            }
            Console.ReadLine();
        }
    }
}
