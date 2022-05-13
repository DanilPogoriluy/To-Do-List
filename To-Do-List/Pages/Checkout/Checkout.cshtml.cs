using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace To_Do_List.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string MissionText { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(MissionText)) MissionText = "Empty";
        }
    }
}
