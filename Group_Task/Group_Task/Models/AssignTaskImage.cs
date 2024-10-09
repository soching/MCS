using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("AssignTask_Image")]
    public partial class AssignTaskImage
    {
        [Key]
        [Column("Image_ID")]
        public int ImageId { get; set; }
        [Column("Image_Name")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ImageName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Uploader { get; set; }
        [Column("Work_Location")]
        [MaxLength(50)]
        public byte[]? WorkLocation { get; set; }
        [MaxLength(8)]
        public byte[]? Time { get; set; }
    }
}
