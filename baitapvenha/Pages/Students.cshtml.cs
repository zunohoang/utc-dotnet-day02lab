using Microsoft.AspNetCore.Mvc.RazorPages;

namespace baitapvenha.Pages
{
    public class StudentsModel : PageModel
    {
        public List<string> StudentList { get; set; } = new List<string> { "Nguyen Van A", "Tran Thi B", "Le Van C" };
        public string? StudentDetail { get; set; }

        public void OnGet(string? name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                StudentDetail = $"Chi ti?t h?c sinh: {name}";
            }
        }
    }
}
