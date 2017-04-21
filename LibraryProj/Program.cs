using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Library YSULib = new Library("YSU library");
            Library AUALib = new Library("AUA library");
            //Console.WriteLine(Library.ObjectsInMemory);
            Book book1 = new Book("Genius", "T. Draiser", 1914);
            Book book2 = new Book("Idiot", "F. Dostoevskiy", 1869);
            Book book3 = new Book("Shunn u Katun", "H. Tumanyan", 1922);
            YSULib.AddBook(book1);
            YSULib.AddBook(book2);
            YSULib.AddBook(book3);
            YSULib.Print();
            Console.WriteLine("Books by Tumanyan: ");
            List<Book> booksByTumanyan = YSULib.SearchByAuthor("H. Tumanyan");
            foreach (Book book in booksByTumanyan)
            {
                book.Print();
            }
            YSULib.RemoveByAuthor("H. Tumanyan");
            YSULib.Print();
        }
    }
}
