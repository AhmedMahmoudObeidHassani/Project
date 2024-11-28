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
                    Console.WriteLine("library:");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Search Book");
                    Console.WriteLine("3. Delete Book");
                    Console.WriteLine("4. View All Books");
                    Console.WriteLine("5. Exit");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        library.Add(new Book(title, author));
                        Console.WriteLine("Book added!");
                    }
                    else if (choice == "2") 
                    {
                        Console.Write("Enter search term (Title or Author): ");
                        string searchTerm = Console.ReadLine();
                        foreach (var book in library)
                        {
                            if (book.bookTitle.Contains(searchTerm) || book.bookAuthor.Contains(searchTerm))
                            {
                                Console.WriteLine(book);
                            }
                        }
                    }
                    else if (choice == "3")
                    {
                        Console.Write("Enter title to delete: ");
                        string titleToDelete = Console.ReadLine();
                        int indexToRemove = -1;

                        for (int i = 0; i < library.Count; i++)
                        {
                            if (library[i].bookTitle.Equals(titleToDelete))
                            {
                                indexToRemove = i;
                                break;
                            }
                        }

                        if (indexToRemove != -1)
                        {
                            library.RemoveAt(indexToRemove);
                            Console.WriteLine("Book deleted!");
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                    }
                    else if (choice == "4")
                    {
                        if (library.Count > 0)
                        {
                            foreach (var book in library)
                            {
                                Console.WriteLine(book);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Library is empty.");
                        }
                    }
                    else if (choice == "5")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                    }
                }

            }



        }

    }
}
