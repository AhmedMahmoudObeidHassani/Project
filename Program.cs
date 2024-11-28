using System.Threading.Channels;

namespace Project
{
    public class Book
    {
        public string bookTitle;
        public string bookAuthor;
        public Book(string booktitle, string bookauthor)
        {
            bookTitle = booktitle;
            bookAuthor = bookauthor;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Book> library = new List<Book>();

                while (true)
                {

                }
                
                   

            }
        }
    }
}