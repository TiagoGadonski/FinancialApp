using FinancialApp.ApiService.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancialApp.ApiService.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ShoppingItem> ShoppingItems { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<PaymentReminder> PaymentReminders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=FinancialApp.db");
        }
    }
}
