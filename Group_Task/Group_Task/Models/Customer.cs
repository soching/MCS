using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(150)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Sex { get; set; }
        [StringLength(250)]
        public string? Tel { get; set; }
        [StringLength(250)]
        public string? Address { get; set; }
        [Column("BOD", TypeName = "datetime")]
        public DateTime? Bod { get; set; }
        [StringLength(250)]
        public string? CurrentAddress { get; set; }
        [StringLength(150)]
        public string? Career { get; set; }
        [StringLength(100)]
        public string? MarriedStatus { get; set; }
        [StringLength(100)]
        public string? PartnerStatus { get; set; }
        [Column("SocialID")]
        [StringLength(50)]
        public string? SocialId { get; set; }
        [StringLength(150)]
        public string? Nationality { get; set; }
        [StringLength(150)]
        public string? Name1 { get; set; }
        [StringLength(50)]
        public string? Sex1 { get; set; }
        [StringLength(100)]
        public string? Tel1 { get; set; }
        [StringLength(250)]
        public string? Address1 { get; set; }
        [Column("BOD1", TypeName = "datetime")]
        public DateTime? Bod1 { get; set; }
        [StringLength(150)]
        public string? Career1 { get; set; }
        [StringLength(250)]
        public string? CurrentAddress1 { get; set; }
        [StringLength(100)]
        public string? MarriedStatus1 { get; set; }
        [StringLength(100)]
        public string? PartnerStatus1 { get; set; }
        [Column("SocialID1")]
        [StringLength(50)]
        public string? SocialId1 { get; set; }
        [StringLength(150)]
        public string? Nationality1 { get; set; }
        [Column("Refer_No")]
        public int? ReferNo { get; set; }
        [StringLength(250)]
        public string? HouseType { get; set; }
        [StringLength(50)]
        public string? HouseNo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? HousePrice { get; set; }
        [StringLength(150)]
        public string? CustomerType { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Income { get; set; }
        [StringLength(250)]
        public string? Reason2Buy { get; set; }
        [Column("Seller_Name")]
        [StringLength(150)]
        public string? SellerName { get; set; }
        [Column("lead_id")]
        public int? LeadId { get; set; }
    }
}
