using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Journal journal1 = new Journal();
            List<Entry> entries = journal1.GetAllEntries();
            int i = -1;
            while (i != 5)
            {
                ///Display menu options
                //1. Write 2. display 3. load 4. save 5. quit
                Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
                i = int.Parse(Console.ReadLine());
                Prompt prompt = new Prompt();
                journal1.fileName = "";

                if (i == 1)
                {
                    Entry entry1 = new Entry();
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
                    string filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach(string line in lines)
                    {
                        string[] parts = line.Split('~');
                        Entry entry2 = new Entry();
                        entry2.date = parts[0];
                        entry2.prompt = parts[1];
                        entry2.response = parts[2];
                        entry2.Hold($"{entry2.prompt}", $"{entry2.response}", $"{entry2.date}");
                        journal1.AddEntry(entry2);
                    } 
                }
                else if (i == 4)
                {
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach (Entry entry in entries)
                        {
                            string output = $"{entry.date}~{entry.prompt}~{entry.response}";
                            outputFile.WriteLine(output);
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}