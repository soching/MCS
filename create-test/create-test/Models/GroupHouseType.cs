using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
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
