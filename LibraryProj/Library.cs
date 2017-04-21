using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProj
{
    class Library
    {
        private static int COUNT = 0;
        private String name;
        private List<Book> books;
        public String Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public List<Book> Books
        {
            get { return books; }
            set { this.books = value; }
        }
        public Library (String name)
        {
            this.Name = name;
            Books = new List<Book>();
            COUNT++;
        }
        public void AddBook(Book b)
        {
            Books.Add(b);
        }
        public void RemoveByTitle(String title)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (title == Books[i].Title)
                    Books.RemoveAt(i);
            }
        }
        public void RemoveByAuthor(String author)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (author == Books[i].Author)
                    Books.RemoveAt(i);
            }
        }
        public List<Book> SearchByAuthor(String author)
        {
            List<Book> authorBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (author == book.Author)
                    authorBooks.Add(book);
            }
            return authorBooks;
        }

        public List<Book> SearchByTitle(String title)
        {
            List<Book> booksWithTitle = new List<Book>();
            foreach (Book book in Books)
            {
                if (title == book.Title)
                    booksWithTitle.Add(book);
            }
            return booksWithTitle;
        }
        public void Print()
        {
            Console.WriteLine("Library name: {0}", Name);
            foreach (Book book in Books)
            {
                book.Print();
            }
        }
        public static int ObjectsInMemory
        {
            get { return COUNT; }
        }
    }
}