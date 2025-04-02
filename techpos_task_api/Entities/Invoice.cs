using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace techpos_task_api.Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; }
        [ForeignKey("Customer")]
        public int CustomerId { get; }
        public InvoiceDetail Detail { get; set; } = new InvoiceDetail();
    }
}
