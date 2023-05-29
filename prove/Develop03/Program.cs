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

            Console.WriteLine(scripture1.DisplayScripture());

        }
    }
}