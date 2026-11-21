using Microsoft.AspNetCore.Mvc;

namespace StudentCourseRegistrationMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
