﻿namespace FinancialApp.ApiService.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Relacionamentos
        public virtual ICollection<Transaction> Transactions { get; set; }

        public Category()
        {
            Transactions = new HashSet<Transaction>();
        }

        // Métodos auxiliares
        public void UpdateCategoryDetails(string newName, string newDescription)
        {
            Name = newName;
            Description = newDescription;
        }
    }
}
