using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string? Description { get; set; }

        public int? UserID { get; set; }
        public User? User { get; set; }

        public List<Transaction> Transactions { get; set; } = new();
    }
}
