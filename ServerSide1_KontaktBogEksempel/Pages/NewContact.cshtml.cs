using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServerSide1_KontaktBogEksempel.Models;
using ServerSide1_KontaktBogEksempel.Services;

namespace ServerSide1_KontaktBogEksempel.Pages
{
    public class NewContactModel : PageModel
    {

        private IContactService _contactService;

        public NewContactModel(IContactService contactService)
        {
            _contactService = contactService;
        }

        [BindProperty]
        public ContactInfo? Contact { get; set; }

        public void OnGet() {}

        public IActionResult OnPost() 
        {
            if (Contact != null)
            {
                _contactService.AddContact(Contact);
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
