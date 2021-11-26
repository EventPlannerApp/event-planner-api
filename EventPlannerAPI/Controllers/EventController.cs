using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventPlannerAPI.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventPlannerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public Event Get()
        {
            return new Event("New Years Eve", "Ottawa", 20, 100000);
        }
    }
}
