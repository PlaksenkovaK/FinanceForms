using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public enum AccountType
    {
        [Display(Name = "$")]
        USD,
        [Display(Name = "Руб.")]
        RUB,
        [Display(Name = "€")]
        EUR,
    }

    public class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string AccountName { get; set; }
        public AccountType AccountType { get; set; } = AccountType.RUB;
        public int UserID { get; set; }
        public User? User { get; set; }

        public List<Transaction> Transactions { get; set; } = new();
    }
}
