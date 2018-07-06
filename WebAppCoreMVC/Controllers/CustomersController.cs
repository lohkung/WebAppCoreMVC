﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppCoreMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppCoreMVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public String getCustomerByID(int id)
        {
            return $"ข้อมูลลูกค้ารหัส : {id}";
        }
    }
}
