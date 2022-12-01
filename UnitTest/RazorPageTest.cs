using ServerSide1_KontaktBogEksempel.Pages;
using ServerSide1_KontaktBogEksempel.Services;
using Moq;
using ServerSide1_KontaktBogEksempel.Models;

namespace UnitTest
{
    public class RazorPageTest
    {
        [Fact]
        public void TestContactReturn()
        {
            //Arrange
            var service = new Mock<IContactService>();

            List<ContactInfo> expectedContacts = new()
            {
                new ContactInfo() { ContactId = 1 ,Name = "1", Email = "1@1.1" },
                new ContactInfo() { ContactId = 2 , Name = "1", Email = "1@1.1" },
                new ContactInfo() { ContactId = 3 , Name = "1", Email = "1@1.1" },
                new ContactInfo() { ContactId = 4 , Name = "1", Email = "1@1.1" },
                new ContactInfo() { ContactId = 5 , Name = "1", Email = "1@1.1" }
            };

            service.Setup(s => s.GetContacts()).Returns(expectedContacts);
            var Page = new IndexModel(service.Object);

            //Act
            Page.OnGet();

            //Assert
            Assert.Equal(expectedContacts, Page.Contacts);
        }
    }
}