using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dashbord.Models;

namespace dashbord.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    //public IActionResult Clinics()
    //{
    //    return View();
    //}

    public IActionResult Patients()
    {
        return View();
    }
    
    public IActionResult medicalInfo()
    {
        return View();
    }

    //public IActionResult Doctors()
    //{
    //    return View();
    //}
    
    public IActionResult MyPatients()
    {
        return View();
    }
    public IActionResult Medicines()
    {
        return View();
    }

    public IActionResult Settings()
    {
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

