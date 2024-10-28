using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string? Note { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
