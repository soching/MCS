using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Profile")]
    public partial class Profile
    {
        [Key]
        [Column("Profile_ID")]
        public int ProfileId { get; set; }
        [Column("Profile_Name")]
        [StringLength(500)]
        public string? ProfileName { get; set; }
        [Column("Default_Page")]
        [StringLength(500)]
        public string? DefaultPage { get; set; }
    }
}
