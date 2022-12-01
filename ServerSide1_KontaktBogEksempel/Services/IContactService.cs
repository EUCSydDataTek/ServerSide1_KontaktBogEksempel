using ServerSide1_KontaktBogEksempel.Models;

namespace ServerSide1_KontaktBogEksempel.Services
{
    public interface IContactService
    {

        public List<ContactInfo> GetContacts();

        public ContactInfo GetContact(int id);

        public int GetContactCount();

        public void AddContact(ContactInfo contact);
    }
}
