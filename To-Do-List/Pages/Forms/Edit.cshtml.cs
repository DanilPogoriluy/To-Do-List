using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using To_Do_List.Data;
using To_Do_List.Models;

namespace To_Do_List.Pages.Forms
{
    [BindProperties(SupportsGet = true)]
    public class EditModel : PageModel
    {
        public int Id { get; set; }

        public string MissionText { get; set; }

        public Missions missions { get; set; }

        public readonly ApplicationContext _context;

        public EditModel(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            missions = new Missions();

            missions.Id = Id;
            missions.MissionText = MissionText;
            missions.DateTime = DateTime.Now;

            _context.MissionsOrder.Update(missions);
            _context.SaveChanges();

            return RedirectToPage("/Index");
        }
    }
}
