using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PrimeiroWebApp.Models;

namespace PrimeiroWebApp.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });
            list.Add(new Department { Id = 3, Name = "Home" });
            list.Add(new Department { Id = 4, Name = "Cosmetics" });

            return View(list);
        }
    }
}
