using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting.Internal;
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

        [BindProperty]
        public IFormFile? ContactPicture { get; set; }

        public void OnGet() {}

        public async Task<IActionResult> OnPost() 
        {
            if (Contact != null)
            {
                if (ContactPicture != null)
                {

                    string FullPath = Path.Combine(Path.GetFullPath("wwwroot"),"Images",ContactPicture.FileName);

                    FileStream file = System.IO.File.Create(FullPath);
                    await ContactPicture.CopyToAsync(file);
                    file.Close();

                    Contact.ImagePath = Path.Combine("Images",ContactPicture.FileName);
                }

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
