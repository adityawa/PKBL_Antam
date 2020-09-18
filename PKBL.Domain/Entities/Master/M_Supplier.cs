using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PKBL.Domain.Entities.Master
{
    public class M_Supplier : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string SupplierName { get; set; }
        public string Alamat { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Keterangan { get; set; }
        public string Pic { get; set; }
        public string Jabatan { get; set; }
        public string BranchCode { get; set; }
        public string SupplierCode { get; set; }
        public DateTime? TglDaftar { get; set; }
        public string group_penokode { get; set; }
    }
}
