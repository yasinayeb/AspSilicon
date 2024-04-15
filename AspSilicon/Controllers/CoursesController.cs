using Microsoft.AspNetCore.Mvc;

namespace AspSilicon.Controllers;

public class CoursesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
