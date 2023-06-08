using System;
using System.Collections.Generic;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture1 = new Scripture();
            Verse verse1 = new Verse();
            
            scripture1.SetVerse("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
            scripture1.SetReference("John", "3", "16");
            string[] words = scripture1.GetVerse().Split(" ");

            Console.WriteLine(scripture1.DisplayScripture());
            Console.WriteLine("Press enter to hide words in the verse or type 'quit' to stop.");
            string input = Console.ReadLine();
            while (input != "quit")
            {
                Console.Clear();

                List<int> remainingIndexes = GetRemainingIndexes(words.Length);
                List<int> randomIndexes = GenerateRandomIndexes(remainingIndexes.Count, 4);

                foreach (int index in randomIndexes)
                {
                    words[index] = "_";
                }

                Console.WriteLine(scripture1.GetReference());
                Console.WriteLine(verse1.ConvertToString(words));  

                Console.WriteLine("Press enter to hide more words in the verse or type 'quit' to stop.");
                input = Console.ReadLine();
            }      
        }

        static List<int> GetRemainingIndexes(int totalWords)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < totalWords; i++)
            {
                indexes.Add(i);
            }
            return indexes;
        }

        static List<int> GenerateRandomIndexes(int range, int count)
        {
            List<int> indexes = new List<int>();

            // Create a list of all possible indexes within the range
            List<int> allIndexes = new List<int>();
            for (int i = 0; i < range; i++)
            {
                allIndexes.Add(i);
            }

            // Generate random indexes
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int randomIndex = random.Next(0, allIndexes.Count);
                indexes.Add(allIndexes[randomIndex]);
                allIndexes.RemoveAt(randomIndex);
            }

            return indexes;
        }  
    }
}
