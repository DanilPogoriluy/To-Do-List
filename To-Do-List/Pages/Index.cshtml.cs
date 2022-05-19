using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using To_Do_List.Data;
using To_Do_List.Models;

namespace To_Do_List.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;

        public IList<Missions> Missions { get; set; }

        public IndexModel(ApplicationContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Missions = await _context.MissionsOrder
                .AsNoTracking()
                .ToListAsync();
        }

        public IActionResult OnGetDelete(int id)
        {
            _context.Remove(_context.MissionsOrder.Find(id));
            _context.SaveChanges();
            return RedirectToPage("Index");
        }

        public IActionResult OnGetEdit(int id)
        {
            var mission = new Missions();
            mission.Id = id;
            return RedirectToPage("/Forms/Edit", new {mission.Id});
        }
    }
}