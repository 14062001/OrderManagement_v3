using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement_v3.Models
{
    public class Order
    {
        [Key]
        public int Order_id { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string Order_details { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Status { get; set; }
        [DataType(DataType.Date)]
        public DateTime Order_date { get; set; }
        [DataType(DataType.Date)]
        public DateTime Shipment_date { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string Delivery_Address { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Payment_method { get; set; }
        public int Total_Price { get; set; }
        public virtual Customer customer { get; set; }
    }
}
