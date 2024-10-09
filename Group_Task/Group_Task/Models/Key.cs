using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Key")]
    public partial class Key
    {
        [Key]
        [Column("Key_ID")]
        public int KeyId { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        [StringLength(150)]
        public string? Model { get; set; }
        [Column("Key_E0")]
        public int? KeyE0 { get; set; }
        [Column("Key_E1")]
        public int? KeyE1 { get; set; }
        [Column("Key_E2")]
        public int? KeyE2 { get; set; }
        [Column("House_Type_ID")]
        public int HouseTypeId { get; set; }
        [StringLength(500)]
        public string? Note { get; set; }
    }
}
