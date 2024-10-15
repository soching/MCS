using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Lead")]
    public partial class Lead
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Sex { get; set; }
        [StringLength(100)]
        public string? Tel { get; set; }
        public int? Source { get; set; }
        [StringLength(500)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? Status { get; set; }
        [Column("Sale_Name")]
        [StringLength(150)]
        public string? SaleName { get; set; }
        [StringLength(150)]
        public string? Facebook { get; set; }
        [StringLength(150)]
        public string? Telegram { get; set; }
        [StringLength(150)]
        public string? WhatsApp { get; set; }
        [Column("Created_Date", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string? Age { get; set; }
        [Column("IRHouseType")]
        [StringLength(250)]
        [Unicode(false)]
        public string? IrhouseType { get; set; }
        [StringLength(50)]
        public string? FirstContactDate { get; set; }
        [Column("Customer_Type")]
        [StringLength(50)]
        public string? CustomerType { get; set; }
        [StringLength(150)]
        public string? Occupation { get; set; }
        public bool? Converted { get; set; }
        [Column("Marital_Status")]
        [StringLength(50)]
        public string? MaritalStatus { get; set; }
        [StringLength(250)]
        public string? OtherOccupation { get; set; }
    }
}
