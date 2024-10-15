using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Group_Con")]
    public partial class GroupCon
    {
        [Key]
        [Column("Group_ID")]
        public int GroupId { get; set; }
        [Column("Group_Name")]
        [StringLength(250)]
        public string? GroupName { get; set; }
    }
}
