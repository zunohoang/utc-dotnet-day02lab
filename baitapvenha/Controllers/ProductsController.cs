using Microsoft.AspNetCore.Mvc;

namespace baitapvenha.Controllers;

public class ProductsController : Controller
{
    private static readonly List<(int Id, string Name, decimal Price)> _data = new()
    {
        (1, "Bàn phím cơ", 750000),
        (2, "Chuột gaming", 390000),
        (3, "Màn hình 24\"", 2790000)
    };

    // GET: /Products
    public IActionResult Index(string? q)
    {
        var items = string.IsNullOrWhiteSpace(q)
            ? _data
            : _data.Where(p => p.Name.Contains(q, StringComparison.OrdinalIgnoreCase)).ToList();

        return View(items);
    }

    // GET: /Products/Detail/2  hoặc /p/2/chuot-gaming (route đẹp)
    public IActionResult Detail(int id, string? slug)
    {
        var p = _data.FirstOrDefault(x => x.Id == id);
        if (p == default) return NotFound();

        ViewBag.Slug = slug;
        return View(p);
    }
}
