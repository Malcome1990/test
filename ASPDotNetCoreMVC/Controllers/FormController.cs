using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPDotNetCoreMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCoreMVC.Controllers
{
    public class FormController : Controller
    {
        private readonly DataContext _context;
        public FormController(DataContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }



        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}