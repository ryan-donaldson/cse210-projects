using System;
using System.Collections.Generic;


namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            while (i != 5)
            {
                ///Display menu options
                //1. Write 2. display 3. load 4. save 5. quit
                Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
                i = int.Parse(Console.ReadLine());
                Entry entry1 = new Entry();
                Journal journal1 = new Journal();
                Prompt prompt = new Prompt();
                List<Entry> entries = journal1.GetAllEntries();
                journal1.fileName = "";

                if (i == 1)
                {
                    string date = "May 11 2023";
                    string promptUser = prompt.GetRandomPrompt();
                    Console.WriteLine(promptUser);
                    string response = Console.ReadLine();
                    entry1.Hold($"{promptUser}", $"{response}", $"{date}");
                    journal1.AddEntry(entry1);
                }
                else if (i == 2)
                {
                    foreach (Entry entry in entries)
                    {
                        string message = entry.ConvertToString();
                        Console.WriteLine(message);
                    }
                }
                else if (i == 3)
                {
                    Console.WriteLine("What is the filename?");
                    journal1.fileName = Console.ReadLine();
                    journal1.LoadFromFile();
                }
                else if (i == 4)
                {
                    Console.WriteLine("What is the filename?");
                    journal1.fileName = Console.ReadLine();
                    journal1.SavetoFile();
                }
                else
                {
                    break;
                }
            }
        }
    }
}