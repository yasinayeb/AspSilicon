using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspSilicon.Controllers;



public class DefaultController : Controller
{
    public IActionResult Home()
    {
        return View();
    }
}
