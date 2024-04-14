using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspSilicon.Controllers;


[Authorize]
public class DefaultController : Controller
{
    public IActionResult Home()
    {
        return View();
    }
}
