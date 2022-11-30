namespace ServerSide1_KontaktBogEksempel.Models
{
    public class ContactInfo
    {

        public int ContactId { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public string Phone { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;
    }
}
