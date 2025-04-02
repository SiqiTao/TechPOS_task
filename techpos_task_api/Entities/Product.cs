using System.ComponentModel.DataAnnotations;

namespace techpos_task_api.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
