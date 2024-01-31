using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProgrammingAsssignment1.Models;

namespace ProgrammingAsssignment1.Pages.Person_Models
{
    public class AddInfoModel : PageModel
    {
        private readonly ILogger<AddInfoModel> _logger;

        [BindProperty(SupportsGet = true)]

        public PersonInfo CurrentPerson { get; set; }

        public AddInfoModel(ILogger<AddInfoModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogInformation("AddInfo OnGet called");
            _logger.LogInformation($"Name: {CurrentPerson.Name}");
            _logger.LogInformation($"Age: {CurrentPerson.Age}");
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("AddInfo OnPost called");
            _logger.LogInformation($"Name: {CurrentPerson.Name}");
            _logger.LogInformation($"Age: {CurrentPerson.Age}");

            if (ModelState.IsValid)
            {
                return RedirectToPage("./Index", CurrentPerson);
            }
            else
            {
                return Page();
            }
        }
    }
}
