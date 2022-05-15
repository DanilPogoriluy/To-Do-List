using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using To_Do_List.Data;
using To_Do_List.Models;

namespace To_Do_List.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string MissionText { get; set; }

        private readonly ApplicationContext _context;

        public CheckoutModel(ApplicationContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(MissionText)) MissionText = "Empty";

            var mission = new Missions();
            mission.MissionText = MissionText;
            mission.DateTime = DateTime.Now;

            _context.MissionsOrder.Add(mission);
            _context.SaveChanges();
        }
    }
}
