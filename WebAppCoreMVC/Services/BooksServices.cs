using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCoreMVC.Models;

namespace WebAppCoreMVC.Services
{
    public class BooksServices : IBooksServices
    {
        public Book GetBooksData()
        {
            Book b = new Book
            {
                ISBN = "1111" + "-" + GetHashCode(),
                Title = "คู่มือ VB",
                Price = 299
            };
            return b;
        }

        
    }
}
