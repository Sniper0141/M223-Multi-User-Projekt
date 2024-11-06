using M223_Multi_User_Projekt.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace M223_Multi_User_Projekt.Controllers;

[Controller]
public class HomeController : Controller
{
    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {
        return View("DefaultView", new DefaultViewModel{ Title = "default-view-model" });
    }
}