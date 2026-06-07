using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PasteBin.Services
{
    /// <summary>
    /// Base page model that requires authentication
    /// </summary>
    public class AuthPageModel : PageModel
    {
        /// <summary>
        /// Checks authentication before executing any page handler
        /// </summary>
        public override void OnPageHandlerExecuting(Microsoft.AspNetCore.Mvc.Filters.PageHandlerExecutingContext context)
        {
            if (HttpContext.Session.GetString("authenticated") != "true")
                context.Result = RedirectToPage("/Index");
        }
    }
}