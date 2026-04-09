using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>
            {
                new Department { Id = 1, Name = "Computers" },
                new Department { Id = 2, Name = "Electronics" },
                new Department { Id = 3, Name = "Fashion" },
                new Department { Id = 4, Name = "Books" }
            };
            return View(list);
        }
    }
}
