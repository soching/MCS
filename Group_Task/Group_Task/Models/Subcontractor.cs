using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Subcontractor")]
    public partial class Subcontractor
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("project_name")]
        [StringLength(250)]
        public string? ProjectName { get; set; }
        [Column("id_card")]
        [StringLength(250)]
        public string? IdCard { get; set; }
        [Column("sub_name")]
        [StringLength(250)]
        public string? SubName { get; set; }
        [Column("tel")]
        public int? Tel { get; set; }
        [Column("sub_address")]
        [StringLength(250)]
        public string? SubAddress { get; set; }
        [Column("sub_type")]
        [StringLength(250)]
        public string? SubType { get; set; }
        [Column("sub_status")]
        [StringLength(100)]
        public string? SubStatus { get; set; }
    }
}
