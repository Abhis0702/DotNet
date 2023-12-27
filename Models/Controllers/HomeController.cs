using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;
//namespace System.Collections;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Person p1 = new Person{Id = 12, First_Name = "Shailesh", Last_Name = "Patil"};
        Person p2 = new Person{Id = 13, First_Name = "Abhi", Last_Name = "Shahane"};
        Person p3 = new Person{Id = 14, First_Name = "Rutwik", Last_Name = "Kshirsagar"};

        List<Person> family = new List<Person>();
        family.Add(p1);
        family.Add(p2);
        family.Add(p3);

        this.ViewData["bfamily"] = family;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
