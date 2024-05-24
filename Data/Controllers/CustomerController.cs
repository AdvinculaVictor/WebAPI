using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Entities;

namespace WebAPI.Data.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            List<Customer> list = new List<Customer>();
            list.Add(new Customer { Name = "",});
            return (IActionResult)list;
        }
    }
}