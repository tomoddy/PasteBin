using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PasteBin.Pages
{
    /// <summary>
    /// Login page
    /// </summary>
    /// <param name="configuration">Configuration</param>
    public class IndexModel(IConfiguration configuration) : PageModel
    {
        /// <summary>
        /// Whether the password was incorrect
        /// </summary>
        public bool Error { get; set; } = false;

        /// <summary>
        /// Render the page
        /// </summary>
        public void OnGet() { }

        /// <summary>
        /// Check password and redirect
        /// </summary>
        public IActionResult OnPost(string password)
        {
            if (password != configuration["Password"])
            {
                Error = true;
                return Page();
            }

            HttpContext.Session.SetString("authenticated", "true");
            return RedirectToPage("/Pastes/Index");
        }
    }
}