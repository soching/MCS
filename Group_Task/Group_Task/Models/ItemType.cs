using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("ItemType")]
    public partial class ItemType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("group_name")]
        [StringLength(250)]
        public string? GroupName { get; set; }
        [Column("group_code")]
        [StringLength(250)]
        public string? GroupCode { get; set; }
        [Column("sub_of")]
        [StringLength(250)]
        public string? SubOf { get; set; }
        [Column("sub_of_code")]
        [StringLength(250)]
        public string? SubOfCode { get; set; }
        [Column("descriptions")]
        [StringLength(250)]
        public string? Descriptions { get; set; }
        [Column("company_code")]
        [StringLength(250)]
        public string? CompanyCode { get; set; }
        [Column("create_by")]
        [StringLength(250)]
        public string? CreateBy { get; set; }
        [Column("item_status")]
        [StringLength(50)]
        public string? ItemStatus { get; set; }
    }
}
