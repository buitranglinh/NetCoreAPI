using Microsoft.AspNetCore.Mvc;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    { 
        // GET: /Employee/
        public IActionResult Index()
        {
            return View();
        } 
        // GET: /Employee/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}