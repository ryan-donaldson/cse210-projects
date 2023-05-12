using System.Collections.Generic;
using System;

namespace Develop02
{
    ///<summary>
    ///The responsibility of a Prompt is to receive an answer from the user
    ///<summary>

    class Prompt
    {
        public List<string> promptsList = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?",
        "What did you have for breakfast this morning?", "What was the weather like today?", "What did you do to have fun today?"};
        static Random rnd = new Random();
        public string GetRandomPrompt()
        {
            int r = rnd.Next(promptsList.Count);
            return promptsList[r];
        }
    }
}
    
    