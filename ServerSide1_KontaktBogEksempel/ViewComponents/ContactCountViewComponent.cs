using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using ServerSide1_KontaktBogEksempel.Services;

namespace ServerSide1_KontaktBogEksempel.ViewComponents
{
    [ViewComponent]
    public class ContactCountViewComponent : ViewComponent
    {

        private IContactService _ContactService;

        public ContactCountViewComponent(IContactService contactService)
        {
            _ContactService = contactService;
        }

        public Task<ViewViewComponentResult> InvokeAsync()
        {
            int count = _ContactService.GetContactCount();

            return Task.FromResult(View(count));
        }
    }
}
