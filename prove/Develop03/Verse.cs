using System.Collections.Generic;
using System.IO;

namespace Develop03
{
    ///<summary>
    ///The responsibility of Verse is to hold and contain a list of words in a verse
    public class Verse
    {
        private string _verse = "";
        private List<Word> _words;

        public Verse()
        {
            _words = new List<Word>();
        }

        public void AddWord(Word word)
        {
            _words.Add(word);
        }
        public string ConvertToString()
        {
            foreach (Word w in _words)
            {
                _verse += w.ConvertToString();
            }
            return _verse;
        }
    }
}