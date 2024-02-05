using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesLinks.Pages.MyPages
{
    public class Page1Model : PageModel
    {
        public string? Message { get; set; }
        public void OnGet(string message)
        {
            Message = message;
        }
    }
}
