using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
    }
}
