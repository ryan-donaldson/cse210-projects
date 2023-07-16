namespace Foundation1
{

    ///<summary>
    /// This class holds comments and their info
    ///<summary>

    public class Comment
    {
        private string _author;
        private string _text;

        public Comment(string author, string text)
        {
            _author = author;
            _text = text;
        }

        public void GetInfo()
        {
            Console.WriteLine(_author);
            Console.WriteLine(_text);
        }
    }
}