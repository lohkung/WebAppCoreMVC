using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppCoreMVC.Models;
using WebAppCoreMVC.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppCoreMVC.Controllers
{
    public class BooksController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            /*
            Book b = new Book();
            b.ISBN = "12345";
            b.Title = "การพัฒนา Web Apps";
            b.Price = 345;
            */
            BooksStore bs = new BooksStore();
            var bLists =  bs.GetAllBooks();

            
            return View(bLists);
        }
    }
}
