﻿namespace FinancialApp.ApiService.Models
{
    public class ShoppingItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsPurchased { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string Priority { get; set; }
        public int UserId { get; set; }

        // Relacionamento
        public virtual User User { get; set; }

        // Métodos auxiliares
        public void MarkAsPurchased()
        {
            IsPurchased = true;
        }

        public void UpdateItemDetails(string newName, int newQuantity, decimal newPrice)
        {
            Name = newName;
            Quantity = newQuantity;
            Price = newPrice;
        }
    }
}
