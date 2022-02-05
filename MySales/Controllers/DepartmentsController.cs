using Microsoft.AspNetCore.Mvc;
using MySales.Models;
using System.Collections.Generic;

namespace MySales.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();

            list.Add(new Department { Id = 1, Name = "Eletronicos" });
            list.Add(new Department { Id = 2, Name = "Eletro Domesticos" });
            list.Add(new Department { Id = 3, Name = "Acessorios Eletronicos" });
            list.Add(new Department { Id = 4, Name = "Geral" });

            return View(list);
        }
    }
}
