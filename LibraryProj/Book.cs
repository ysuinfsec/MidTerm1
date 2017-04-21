using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProj
{
    class Book
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public int Year { get; set; }
        public Book(String title,String author,int year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }
        public void Print()
        {
            Console.WriteLine("{0}, {1}, {2} ", Title, Author, Year);
        }
    }
}
