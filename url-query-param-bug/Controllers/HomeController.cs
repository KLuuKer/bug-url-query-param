using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace url_query_param_bug.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(
            string a, 
            string b,
            [FromQuery]string c, 
            [FromQuery(Name = "d")]string d,
            string e)
        {
            return View();
        }
    }
}
