using System.Threading.Channels;

namespace Project
{
    public class Book
    {
        public string Title;
        public string Author;
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}