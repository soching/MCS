using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
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
