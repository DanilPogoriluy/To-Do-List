using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using To_Do_List.Models;

namespace To_Do_List.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Missions> missions = new List<Missions>()
        {
            new Missions{Id = 1, DateTime = DateTime.Now, MissionText="Hello World" },
            new Missions{Id = 2, DateTime = DateTime.Now, MissionText="I love u" }
        };

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}