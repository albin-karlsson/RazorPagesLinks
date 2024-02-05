using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesLinks.Pages.MyPages
{
    public class Page3Model : PageModel
    {
        public List<string> WeekDays { get; set; } = new()
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        public void OnGet()
        {
        }
    }
}
