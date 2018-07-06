using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppCoreMVC.Models;

namespace WebAppCoreMVC.Controllers
{
    public class OrdersController : Controller
    {
        private PracticesContext db;

        public OrdersController(PracticesContext ctx)
        {
            db = ctx;
        }

        public async Task<IActionResult> Index()
        {
            var order = await (from o in db.Orders.Include(o => o.Person)
                         orderby o.OrderID
                         select o).ToListAsync();
            return View(order);
        }

        public async Task<ActionResult> SearchOrders(string txtFilter)
        {
            if (string.IsNullOrEmpty(txtFilter))
            {
                return View("Index", await db.Orders.Include(o => o.Person).ToListAsync());
            } else
            {
                return View("Index", await db.Orders.Include(o => o.Person)
                    .Where(o => o.Person.FirstName.Contains(txtFilter)).ToListAsync());
            }
        }

        
    }
}