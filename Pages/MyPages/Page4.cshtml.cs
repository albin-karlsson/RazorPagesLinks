using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesLinks.Pages.MyPages
{
    public class Page4Model : PageModel
    {
        public List<PersonModel> People { get; set; } = new()
        {
            new PersonModel
            {
                Name = "Foo",
                Address = ""
            },
            new PersonModel
            {
                Name = "Baz",
                Address = "",
            }
        };

        public PersonModel? Person { get; set; }

        public void OnGet(string name)
        {
            Person = People.FirstOrDefault(p => p.Name == name);
        }
    }
}
