using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("GLData")]
    public partial class Gldatum
    {
        [Key]
        [Column("GL_ID")]
        public int GlId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrnDte { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AprDte { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? TrnCde { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? TrnTpe { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? VoucherNo { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? ChqNo { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? Payee { get; set; }
        public int? TrnSqu { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? Invoice { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? AccCode { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? SubAcc { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? SubAccTile { get; set; }
        [StringLength(25)]
        public string? AccClass { get; set; }
        [StringLength(25)]
        public string? SiteClass { get; set; }
        [StringLength(3900)]
        public string? Narrative { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [StringLength(25)]
        public string? Company { get; set; }
        [StringLength(25)]
        public string? Company1 { get; set; }
        [StringLength(25)]
        public string? Location { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DrAmt { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CrAmt { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amt { get; set; }
        [Column("CCY")]
        [StringLength(25)]
        public string? Ccy { get; set; }
        [Column("LCY")]
        [StringLength(25)]
        public string? Lcy { get; set; }
        [StringLength(25)]
        public string? Inputter { get; set; }
        [StringLength(25)]
        public string? Authorizer { get; set; }
        [StringLength(25)]
        public string? ChequeGiven { get; set; }
        [StringLength(25)]
        public string? ChequeGivenBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeGivenDate { get; set; }
        [StringLength(25)]
        public string? ChequeReceived { get; set; }
        [StringLength(25)]
        public string? ChequeReceivedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeReceivedDate { get; set; }
        [StringLength(25)]
        public string? ChequeIssuedToSupplier { get; set; }
        [StringLength(25)]
        public string? ChequeIssuedToSupplierBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChequeIssuedToSupplierDate { get; set; }
        [StringLength(25)]
        public string? ChequeReceivedbySupplier { get; set; }
        [StringLength(25)]
        public string? ChequeStatus { get; set; }
        public int? PaidTo { get; set; }
        [Column("Reference_No")]
        public long? ReferenceNo { get; set; }
    }
}
