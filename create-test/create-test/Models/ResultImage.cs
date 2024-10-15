using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("result_image")]
    public partial class ResultImage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("task_file")]
        [StringLength(500)]
        public string? TaskFile { get; set; }
        [Column("constructor_id")]
        public int? ConstructorId { get; set; }
        [Column("house_id")]
        public int? HouseId { get; set; }
        [Column("task_object_id")]
        public int? TaskObjectId { get; set; }
        [Column("setup_task_id")]
        public int? SetupTaskId { get; set; }
        [Column("start_date")]
        [StringLength(200)]
        [Unicode(false)]
        public string? StartDate { get; set; }
        [Column("result_detail_id")]
        public long? ResultDetailId { get; set; }
        [Column("upload_date", TypeName = "datetime")]
        public DateTime? UploadDate { get; set; }
        [Column("username")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Username { get; set; }
        [Column("image_type")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ImageType { get; set; }
        [Column("result_id")]
        public int? ResultId { get; set; }
        [Column("task_master_id")]
        public int? TaskMasterId { get; set; }
        [Column("client_path")]
        [StringLength(500)]
        public string? ClientPath { get; set; }
    }
}
