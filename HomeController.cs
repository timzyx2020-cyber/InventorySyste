using Microsoft.AspNetCore.Mvc;

namespace InventoryMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Products");
    }
}
