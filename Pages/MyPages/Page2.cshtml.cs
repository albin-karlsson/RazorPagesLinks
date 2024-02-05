using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesLinks.Pages.MyPages
{
    public class Page2Model : PageModel
    {
        public PersonModel Person { get; set; } = new()
        {
            Name = "Bob Ross",
            Age = 41,
            Address = "8 C# st."
        };

        public void OnGet()
        {
        }
    }

    public class PersonModel
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
    }
}
