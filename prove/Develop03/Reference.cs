namespace Develop03
{
    ///<summary>
    ///The responsibility of Reference is to hold a reference for a scripture
    ///<summary>
    
    public class Reference
    {
        private string _book;
        private string _chapter;
        private string _verseNumber;
        private string _verseNumber2;
        public Reference(string book, string chapter, string verseNumber)
        {
            _book = book;
            _chapter = chapter;
            _verseNumber = verseNumber;

        }
        public Reference(string book, string chapter, string verseStart, string verseEnd)
        {
            _book = book;
            _chapter = chapter;
            _verseNumber = verseStart;
            _verseNumber2 = verseEnd;
        }
        public void SetBook(string book)
        {
            _book = book;
        }
        public void SetChapter(string chapter)
        {
            _chapter = chapter;
        }
        public void SetVerseNumber(string verse)
        {
            _verseNumber = verse;
        }
        public void SetVerseNumber2(string verse2)
        {
            _verseNumber2 = verse2;
        }
    }
}