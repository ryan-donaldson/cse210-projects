using System;
namespace Develop03
{
    ///<summary>
    ///The responsibility of Scripture is to hold and display a string (scriputre)
    ///<summary>
    
    public class Scripture
    {
        private string _verse = "";
        private string _reference = "";

        public void SetVerse(string verse)
        {
            _verse = verse;
        }
        public void SetReference(string book, string chapter, string verse)
        {
            _reference = $"{book} {chapter}:{verse}";
        }
        public string DisplayScripture()
        {
            string scripture = $"{GetReference()} {GetVerse()}";
            return scripture;
        }
        
        public string ConvertToString()
        {
           return _verse = $"{_verse}";            
        }

        public string GetVerse()
        {
            return _verse;
        }

        public string GetReference()
        {
            return _reference;
        }

    }
}