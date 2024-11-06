using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string NameSurname { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
    }
}
