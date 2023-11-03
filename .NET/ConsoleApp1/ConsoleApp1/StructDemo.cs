using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Book
    {
        public int BookId; 
        public string BookName;
        public float BookPrice;
    }

     class StructDemo
    {

        static void Main(string[] args)
        {
            Book book1;
            book1.BookId= 1;
            book1.BookName = "Hello World";
            book1.BookPrice = 800.7f;
            Console.WriteLine("BookId={0},BookName={1},BookPrice={2}", book1.BookId, book1.BookName, book1.BookPrice);
           Console.ReadKey();

        }
    }
}
