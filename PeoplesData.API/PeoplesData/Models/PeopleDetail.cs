using System.ComponentModel.DataAnnotations;

namespace PeoplesData.Models
{
    public class PeopleDetail
    {
        [Key]
        public Guid PeopleDetailsID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DataofBirth { get; set; }
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
    }
}
