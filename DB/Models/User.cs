using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }

        public List<Account> Accounts { get; set; } = new ();
    }
}
