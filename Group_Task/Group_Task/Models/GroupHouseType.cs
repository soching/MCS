using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Group_House_Type")]
    public partial class GroupHouseType
    {
        [Key]
        public int HouseGroup { get; set; }
        [Column("HouseGroup_Name")]
        [StringLength(500)]
        public string? HouseGroupName { get; set; }
    }
}
