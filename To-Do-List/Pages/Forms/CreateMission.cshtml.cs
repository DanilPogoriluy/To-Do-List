using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using To_Do_List.Models;

namespace To_Do_List.Pages.Forms
{
    public class CreateMissionModel : PageModel
    {
        [BindProperty]
        public Missions missions { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/Checkout/Checkout", new { missions.MissionText });
        }
    }
}
