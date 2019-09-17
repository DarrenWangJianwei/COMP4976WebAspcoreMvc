using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspcoreMvc.Controllers
{
    public class HappyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}