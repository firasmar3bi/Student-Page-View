using Microsoft.AspNetCore.Mvc;
using TaskOneMVC.Data;

namespace TaskOneMVC.Controllers
{
    public class StudentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var Students = context.Students.ToList();
            return View("Index" , Students);
        }
    }
}
