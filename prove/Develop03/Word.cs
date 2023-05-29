namespace Develop03
{
    ///<summary>
    ///The responsibility of Word is to hold a word and change it to blank, if necessary
    ///<summary>
    public class Word
    {
        private string _word;
        public string ConvertToString()
        {
            return $"{_word}";
        }
        
        public void ChangeToBlank()
        {
            _word = "_";
        }
    }
}