using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartTeaching.Models;
using SmartTeaching.Services;

namespace SmartTeaching.Pages
{
    public class HomeworkModel : PageModel
    {
        public List<TestItem> tests = new List<TestItem>();
        public void OnGet()
        {
            tests = TestService.GetAll();
        }
    }
}
