using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement_v3.Models
{
    public class Product
    {
        [Key]
        public int Product_id { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string ProductName { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Size { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Color { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string Product_details { get; set; }
        [DataType(DataType.Url)]
        [Column(TypeName = "varchar(30)")]
        public string ImageUrl { get; set; }
        [DataType(DataType.Currency)]
        public int ProductPrice { get; set; }
    }
}
