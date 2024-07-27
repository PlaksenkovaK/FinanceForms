using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public enum TransactionType
    {
        [Display(Name = "Доход")]
        income,
        [Display(Name = "Расход")]
        expenditure
    }

    public class Transaction
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }

        [Required]
        public TransactionType TransactionType { get; set; } = TransactionType.expenditure;
        public double Amount { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public DateTime TransactionDate { get; set; }

        [Required]
        public int UserID { get; set; }
        public User? User { get; set; }

        public int? AccountID { get; set; }
        public Account? Account { get; set; }
    }
}
