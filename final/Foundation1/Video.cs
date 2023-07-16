namespace Foundation1
{
    ///<summary>
    /// This program holds the info and functionality for videos
    ///<summary>

    public class Video
    {
        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments;

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }

        public int GetCommentsAmount()
        {
            return _comments.Count();
        }

        public void GetInfo()
        {
            Console.WriteLine("Video:");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Duration in seconds: {_length}");
            Console.WriteLine($"Number of comments: {GetCommentsAmount()}");

            Console.WriteLine("Comments: ");
            foreach(Comment comment in _comments)
            {
                comment.GetInfo();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }
    }
}