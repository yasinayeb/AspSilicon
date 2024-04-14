using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspSilicon.Controllers;


[Authorize]
public class OfficeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
