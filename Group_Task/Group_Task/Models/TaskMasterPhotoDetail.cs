using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Task_Master_Photo_Detail")]
    public partial class TaskMasterPhotoDetail
    {
        [Key]
        [Column("MasterD_Photo_ID")]
        public int MasterDPhotoId { get; set; }
        [Column("Master_Photo_ID")]
        public int? MasterPhotoId { get; set; }
        [StringLength(1000)]
        public string? Description { get; set; }
        [Column("Qty_Photo")]
        public int? QtyPhoto { get; set; }
        public int? Autonum { get; set; }
        [Column("imgNum")]
        public int? ImgNum { get; set; }
        [Column("House_No")]
        [StringLength(50)]
        [Unicode(false)]
        public string? HouseNo { get; set; }
    }
}
