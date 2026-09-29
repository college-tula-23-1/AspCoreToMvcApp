using Microsoft.AspNetCore.Mvc;
using AspCoreToMvcApp.Models;

namespace AspCoreToMvcApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //public string Index(string name, int age)
        public string Index(Employee employee)
        {
            return $"Name: {employee.Name}, Age: {employee.Age}";
        }

        [HttpPost]
        public string Employee()
        {
            var form = Request.Form;
            Employee employee = new Employee()
            {
                Name = form["name"],
                Age = Int32.Parse(form["age"])
            };

            return $"Name: {employee.Name}, Age: {employee.Age}";
        }

        [HttpGet]
        public string EmployeeGet()
        {
            var query = Request.Query;
            Employee employee = new Employee()
            {
                Name = query["name"],
                Age = Int32.Parse(query["age"])
            };

            return $"Name: {employee.Name}, Age: {employee.Age}";
        }

        public string About(Employee employee)
        {
            return $"Name: {employee.Name}, Age: {employee.Age}";
        }
    }
}
