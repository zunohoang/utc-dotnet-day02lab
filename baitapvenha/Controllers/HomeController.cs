using Microsoft.AspNetCore.Mvc;

namespace baitapvenha.Controllers;

public class HomeController : Controller
{
    // GET: /
    public IActionResult Index()
    {
        ViewData["Title"] = "Home";
        ViewBag.Message = "Xin chào từ HomeController.Index";
        return View();
    }

    // GET: /Home/About
    public IActionResult About()
    {
        var info = new
        {
            Course = "#Day02Lab - Controller & Route",
            Author = "Bạn Hoàng",
            Date = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
        };
        return View(info);
    }
}
