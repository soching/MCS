using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Transaction")]
    public partial class Transaction
    {
        [Key]
        [Column("HH_ID")]
        public int HhId { get; set; }
        [Column("House_ID")]
        public int? HouseId { get; set; }
        [Column("Customer_ID")]
        public int? CustomerId { get; set; }
        [Column("Transaction_Date", TypeName = "datetime")]
        public DateTime? TransactionDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Type { get; set; }
        [Column("Delivery_Date", TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column("Contract_Date", TypeName = "datetime")]
        public DateTime? ContractDate { get; set; }
        [Column("Warranty_Date", TypeName = "datetime")]
        public DateTime? WarrantyDate { get; set; }
        [Column("Transaction_No")]
        public int? TransactionNo { get; set; }
    }
}
