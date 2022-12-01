using System.Security.Cryptography;
using System.Text;

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

        public string DefaultImage { 
            get {
                using MD5 md5 = MD5.Create();
                byte[] data = Encoding.UTF8.GetBytes(Email);

                data = md5.ComputeHash(data);

                string hash = BitConverter.ToString(data);

                return $"https://robohash.org/{hash}.png?set=set3";
            }
        }

        public string ImagePath = string.Empty;
    }
}
