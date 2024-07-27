using Microsoft.EntityFrameworkCore;
using DB.Models;
using FinanceForms.Service;

namespace FinanceForms.DB
{
    internal class FinanceDbContext : DbContext
    {
        public string DbPath { get; }
        public FinanceDbContext()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Program.AppName.Replace(" ", "_"));
            DbPath = Path.Combine(path, settings.GetSetting("dbfile", "LocalDb.db"));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasMany(u => u.Accounts)
            .WithOne(a => a.User)
            .HasForeignKey(a => a.UserID)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Account>()
                .HasIndex(a => new {a.UserID,a.AccountName })
                .IsUnique();

            modelBuilder.Entity<Category>()
               .HasIndex(a => new { a.UserID, a.CategoryName })
               .IsUnique();

            modelBuilder.Entity<Account>()
                .HasMany(a => a.Transactions)
                .WithOne(t => t.Account)
                .HasForeignKey(t => t.AccountID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .HasMany(u => u.Transactions)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
#if DEBUG || DEMO

            modelBuilder.Entity<Category>().HasData(
             new Category { Id = 1, CategoryName = "Еда" },
             new Category { Id = 2, CategoryName = "Коммунальные услуги" },
             new Category { Id = 3, CategoryName = "Здоровье" },
             new Category { Id = 4, CategoryName = "Отдых" });

            modelBuilder.Entity<User>().HasData(
             new User { Id = 1, Login = "test", Password = "123" });

            modelBuilder.Entity<Account>().HasData(
             new Account { Id = 1, AccountName = "Стандартный",UserID = 1, AccountType = AccountType.RUB  });

            modelBuilder.Entity<Transaction>().HasData(
             new Transaction { Id = 1, CategoryId = 1, Amount = 101.75, UserID = 1, TransactionType = TransactionType.expenditure, TransactionDate = new DateTime(2024, 5, 4) , AccountID = 1 },
             new Transaction { Id = 2, CategoryId = 2, Amount = 103.75, UserID = 1, TransactionType = TransactionType.expenditure, TransactionDate = new DateTime(2024, 5, 10), AccountID = 1 },
             new Transaction { Id = 3, CategoryId = 1, Amount = 105.75, UserID = 1, TransactionType = TransactionType.expenditure, TransactionDate = new DateTime(2024, 5, 15), AccountID = 1 },
             new Transaction { Id = 4, CategoryId = 4, Amount = 110.75, UserID = 1, TransactionType = TransactionType.expenditure, TransactionDate = new DateTime(2024, 5, 20), AccountID = 1 },
             new Transaction { Id = 5, Amount = 1000, UserID = 1, TransactionType = TransactionType.income, TransactionDate = new DateTime(2024, 5, 1), AccountID = 1 });
#endif
            base.OnModelCreating(modelBuilder);
        }

    }
}
