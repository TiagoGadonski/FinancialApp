namespace FinancialApp.ApiService.Models
{
    public class PaymentReminder
    {
        public int ReminderId { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public bool IsPaid { get; set; }

        // Relacionamento
        public virtual User User { get; set; }

        // Métodos auxiliares
        public void MarkAsPaid()
        {
            IsPaid = true;
        }

        public void UpdateReminderDetails(DateTime newDueDate, decimal newAmount, string newDescription)
        {
            DueDate = newDueDate;
            Amount = newAmount;
            Description = newDescription;
        }
    }

}
