using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            Console.WriteLine("Global sync OnPageHandlerExecuting called.");
        }

        public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            Console.WriteLine("Global sync OnPageHandlerExecuted called.");
        }
    }
}