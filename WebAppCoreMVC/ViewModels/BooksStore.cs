using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCoreMVC.Models;

namespace WebAppCoreMVC.ViewModels
{
    public class BooksStore
    {
        IEnumerable<Book> lst;
        public BooksStore()
        {
            lst = new List<Book>
            {
                new Book
                {
                    ISBN  = "1111",
                    Title = "คู่มือ VB",
                    Price = 299
                },
                new Book
                {
                    ISBN = "2222",
                    Title = "คู่มือ VC#",
                    Price = 275
                }
            };
        }

        public IEnumerable<Book> GetAllBooks()
        {
            
            return lst;
        }

      
    }
}
