using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement_v3.Models
{
    public class OrderItems
    {
        [Key]
        public int ReferenceId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string OrderStatus { get; set; }


        public virtual Order order { get; set; }
        public virtual Product product { get; set; }
        
    }
}
