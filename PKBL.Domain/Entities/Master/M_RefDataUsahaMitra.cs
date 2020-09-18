using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PKBL.Domain.Entities.Master
{
    public class M_RefDataUsahaMitra : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string CompSectorDetail { get; set; }
        [Required(ErrorMessage ="This Field Is Mandatory")]
        public string CompName { get; set; }
        public string CompCEO { get; set; }
        public string Address { get; set; }
        [StringLength(5)]
        public string CityId { get; set; }
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(30)]
        public string Phone1 { get; set; }
        [StringLength(30)]
        public string Phone2 { get; set; }
        [StringLength(30)]
        public string Fax { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        public bool OwnWorkPlace { get; set; }
        public DateTime? WorkPlace_Enddate { get; set; }
        public DateTime ActiveSince { get; set; }
        public int Workforce { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal WorkingCapital { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Investment { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MonthlyRevenue { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CompanyUnit { get; set; }
        public bool HasJournalAdmin { get; set; }

        public string JournalAdministration { get; set; }

        public bool HasOtherLoan { get; set; }
        public string OtherLoanAt { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OtherLoanAmt { get; set; }
        public int MitraId { get; set; }

        public string MGRProposalNo { get; set; }
    }

}
