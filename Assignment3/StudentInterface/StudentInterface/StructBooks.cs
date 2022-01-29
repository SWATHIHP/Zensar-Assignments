/* 4. Write a program in C# Sharp to declare a structure called Books with a property, 
 * a method to display the value of Book_id, and a private field called Book_id (int).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterface
{
    struct Books
    {
        public int BookId;
        public string Name;

        private int field
        {
            get { return BookId; }
            set { BookId = value; }
        }

        public void Get()
        {
            Console.Write($"Name of the Book is : {Name} and Book ID is : {BookId}");
        }
    }
    class StructBooks
    {
        static void Main()
        {
            Books book1 = new Books();
            book1.BookId = 111;
            book1.Name = "The Last Lecture";
            book1.Get();
            Books book2 = new Books();
            book2.BookId = 333;
            book2.Name = "The Alchemist";
            book2.Get();
            Books book3 = new Books();
            book3.BookId = 456;
            book3.Name = "The Pilgrimage";
            book3.Get();
            Console.Read();
        }
    }
}
