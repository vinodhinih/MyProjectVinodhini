using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace capgeminisample
//{
//    class Book
//    {
//        public string Name { get; set; }
//        public int Price { get; set; } 

//    }
//    class BookImplementation
//    {
//        public string NameOfAllBooks(IList<Book> books)
//        {
//            return string.Join(" ", books.Select(book => book.Name));
//        }
//        public string PriceOfAllBooks(IList<Book> books)
//        {
//            return string.Join(" ", books.Select(book => book.Price.ToString()));
//        }
//        public int SumPriceOfAllBooks(IList<Book>books)
//        {
//            return books.Sum(book => book.Price);
            
//        }
//        public int Find(IList<Book>book,string s)
//        {
//            for(int i=0;i<book.Count;i++)
//            {
//                if (book[i].Name.Equals(s, StringComparison.OrdinalIgnoreCase))
//                {
//                    return i;
//                }

//            }
//            return -1;
//        }
//    }
//    class Books
//    { 
//        public static void Main(string[]args)
//        {
//            BookImplementation imp = new BookImplementation();
//            IList<Books> bookList = new List<Books>
//            {
//                new Books { Name = "Subtle", Price = 70000 },
//                new Books { Name = "Sapiens", Price = 29000 }
//            };
//            Console.WriteLine(imp.NameOfAllBooks(bookList));
//            Console.WriteLine(imp.PriceOfAllBooks(bookList));
//            Console.WriteLine(imp.Find(bookList, "Sapiens"));
//        }
//    }
//}
