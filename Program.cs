using System;
using System.Collections.Generic;
using System.Linq;

namespace Puzzles
{
  class Program
    {
        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins();
            Names();
        }
        public static void RandomArray()
        {
            int[] RandomArray = new int[10];
            Random random = new Random();
            int maxVal = 5;
            int minVal = 25;
            int sum = 0;
            for (int i=0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = random.Next(5, 26);
                // Console.WriteLine(RandomArray[i]);
                if (RandomArray[i] > maxVal)
                {
                    maxVal = RandomArray[i];
                }
                else if (RandomArray[i] < minVal)
                {
                    minVal = RandomArray[i];
                }
                sum += RandomArray[i];
            }
            Console.WriteLine("[{0}]", string.Join(", ", RandomArray));
            Console.WriteLine($"The maximum value is {maxVal}");
            Console.WriteLine($"The minimum value is {minVal}");
            Console.WriteLine($"The sum of all elements in RandomArray are {sum}");
        }
        public static string TossCoin()
        {
            string CoinToss = "";
            Random random = new Random();
            int randomNum = random.Next(1,3);
            if (randomNum == 1)
            {
                Console.WriteLine("Tossing a Coin!");
                Console.WriteLine("Heads");
                CoinToss = "Heads";
            }
            else if (randomNum == 2)
            {
                Console.WriteLine("Tossing a Coin!");
                Console.WriteLine("Tails");
                CoinToss = "Tails";
            }
            return CoinToss;
        }
        public static double TossMultipleCoins()
        {
            int TotalToss = 100;
            int index = 0;
            double HeadsCounter=0;
            double TailsCounter=0;
            while (index < TotalToss)
            {
                string CoinToss = TossCoin();
                Console.WriteLine($"****You flipped {CoinToss}****");
                if (CoinToss == "Heads")
                {
                    HeadsCounter++;
                    Console.WriteLine("*****Inside the heads function******");
                    index++;
                }
                else if (CoinToss == "Tails")
                {
                    TailsCounter++;
                    Console.WriteLine("*****Inside the tails function******");
                    index++;
                }
            }
            Console.WriteLine($"You flipped heads {HeadsCounter} number of times.");
            Console.WriteLine($"You flipped tails {TailsCounter} number of times.");
            double ratio = HeadsCounter/TotalToss;
            Console.WriteLine($"You're head toss to totaltoss ratio is {ratio}");
            return ratio;
        }
        
        public static List<string> Names()
        {   List<string> NamesGreater5 = new List<string>();
            List<string> ListOfNames = new List<string>(){
                "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
            };
            var shuffled = ListOfNames.OrderBy(x => Guid.NewGuid()).ToList();
            foreach (var name in shuffled)
            {
                // Console.WriteLine("-" + name);
                if (name.Length > 5)
                {
                    NamesGreater5.Add(name);
                }
            }
            foreach (var name in NamesGreater5)
            {
            Console.WriteLine("-" + name);
            }
            return NamesGreater5;
        }
        
    }
}
