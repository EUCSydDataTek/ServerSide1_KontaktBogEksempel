using ServerSide1_KontaktBogEksempel.Models;

namespace ServerSide1_KontaktBogEksempel.Services
{
    public class ContactService : IContactService
    {

        private readonly List<ContactInfo> _Contacts = new List<ContactInfo>();

        public ContactService() 
        {
            _Contacts.Add(new ContactInfo() { ContactId = 1, Name = "Bo" , Email = "Bo@mail.dk", Phone = "123456"});
            _Contacts.Add(new ContactInfo() { ContactId = 2, Name = "Ib", Email = "Ib@mail.dk", Phone = "123456" });
            _Contacts.Add(new ContactInfo() { ContactId = 1, Name = "Lise", Email = "Lise@mail.dk" , Phone = "123456" });
        }

        public ContactInfo? GetContact(int id)
        {
            return _Contacts?.Where(c => c.ContactId == id)?.FirstOrDefault();
        }

        public List<ContactInfo> GetContacts()
        {
            return _Contacts.ToList();
        }
    }
}
