using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("GroupTaskDetail")]
    public partial class GroupTaskDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("grouptask_id")]
        public int? GrouptaskId { get; set; }
        [Column("house_id")]
        public int? HouseId { get; set; }
    }
}
