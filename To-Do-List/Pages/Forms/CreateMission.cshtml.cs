    using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using To_Do_List.Models;

namespace To_Do_List.Pages.Forms
{
    public class CreateMissionModel : PageModel
    {
        List<Missions> MissionArray = new List<Missions>();

        public void OnGet()
        {
        }
    }
}
