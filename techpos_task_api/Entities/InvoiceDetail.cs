using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace techpos_task_api.Entities
{
    public class InvoiceDetail
    {
        [Key, ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public string? ProductDescription { get; set; }
        public string? AdditionInfo { get; set; }
    }
}
