using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProgrammingAsssignment1.Models;

namespace ProgrammingAsssignment1.Pages.Person_Models
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]

        public PersonInfo CurrentPerson { get; set; } = new();
        public void OnGet()
        {
            _logger.LogInformation("Index OnGet Called");
        }
    }
}
