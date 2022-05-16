using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using To_Do_List.Data;
using To_Do_List.Models;

namespace To_Do_List.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationContext _context;

        public IList<Missions> Missions { get; set; }

        public IndexModel(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            //Make Redirect Result in Delete Page
            return RedirectToPage("/Forms/Delete");
        }

        public async Task OnGetAsync()
        {
            Missions = await _context.MissionsOrder
                .AsNoTracking()
                .ToListAsync();
        }
    }
}