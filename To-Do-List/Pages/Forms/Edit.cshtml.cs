using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using To_Do_List.Data;

namespace To_Do_List.Pages.Forms
{
    [BindProperties(SupportsGet = true)]
    public class EditModel : PageModel
    {
        public int Id { get; set; }

        public readonly ApplicationContext _context;

        public EditModel(ApplicationContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }
    }
}
