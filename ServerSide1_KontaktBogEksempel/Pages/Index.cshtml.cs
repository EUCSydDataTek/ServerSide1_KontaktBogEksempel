using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServerSide1_KontaktBogEksempel.Models;
using ServerSide1_KontaktBogEksempel.Services;

namespace ServerSide1_KontaktBogEksempel.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IContactService _ContactService;

        public List<ContactInfo> Contacts { get; set; } = new List<ContactInfo>();

        public IndexModel(ILogger<IndexModel> logger,IContactService contactService)
        {
            _logger = logger;
            _ContactService = contactService;
        }

        public void OnGet()
        {
            Contacts = _ContactService.GetContacts();
        }
    }
}