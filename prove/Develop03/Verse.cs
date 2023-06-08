using System.Collections.Generic;

namespace Develop03
{
    ///<summary>
    ///The responsibility of Verse is to hold and contain a list of words in a verse
    public class Verse
    {
        private string _verse = "";
        private List<string> _words = new List<string>();
        public Verse()
        {
            
        }

        public void AddWord(string word)
        {
            _words.Add(word);
        }
        public string ConvertToString(string[] words)
        {
            foreach (string w in words)
            {
                _verse += $"{w} ";
            }
            return _verse;
        }
    }
}