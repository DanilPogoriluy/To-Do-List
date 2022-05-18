using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using To_Do_List.Data;
using To_Do_List.Models;

namespace To_Do_List.Pages.Forms
{
    public class DeleteModel : PageModel
    {
        public string MissionText { get; set; }
        private readonly ApplicationContext _context;

        public DeleteModel(ApplicationContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(MissionText))
            {
                MissionText = "Empty";
            }

            var mission = new Missions();
            mission.MissionText = MissionText;
            _context.MissionsOrder.Remove(mission);
        }
    }
}
