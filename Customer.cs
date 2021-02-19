using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLibrary
{   
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [Column("customerId")]
        public int CustomerId { get; set;  }
        [Column("customerName")]
        public string CustomerName { get; set; }

        public Customer()
        {

        }
    }
}