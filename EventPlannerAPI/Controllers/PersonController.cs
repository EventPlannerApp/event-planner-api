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
    public class PersonController : Controller
    {
        [HttpGet]
        public Person Get()
        {
            return new Person("Ahmed", "Elehwany", "Ottawa", 23);
        }
    }
}
