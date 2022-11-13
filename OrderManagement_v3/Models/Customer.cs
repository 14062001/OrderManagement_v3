using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement_v3.Models
{
    public class Customer
    {
        [Key]

        public int Cust_id { get; set; }
        [Column(TypeName="varchar(30)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Gender { get; set; }

        [MaxLength(10)]
        public int Mobileno { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string State { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string City { get; set; }
        
        [DataType(DataType.PostalCode)]
        public int Pincode { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string Address { get; set; }
        [Column(TypeName = "varchar(30)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Compare("Password")]
        public string RePassword { get; set; }


    }
}
