using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PKBL.Domain.Entities.PK
{
    public class T_KemitraanPenerimaanProposal : BaseEntity
    {
        [Required]
        public int JenisKredit_Id { get; set; }
        [Required]
        public string ProposalNumber { get; set; }
        [Required]
        public string ProposalTitle { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        [Required]
        public string RequestorName { get; set; }
        [StringLength(15)]
        public string IdentificationType { get; set; }
        [StringLength(99)]
        public string IdentificationNo { get; set; }
        [StringLength(99)]
        public string Birthplace { get; set; }
        public string RequestorParentName { get; set; }

        public int Supplier_Id { get; set; }
        public int Sektor_Id { get; set; }

        public int companyKind { get; set; }
        public string CityID { get; set; }
        public decimal RequestedAmt { get; set; }
        public int Mitra_Id { get; set; }

        public bool IsProposalApproved { get; set; }
        public string ProposalApprovedBy { get; set; }
        public bool ProposalApprovedDate { get; set; }
        [StringLength(1)]
        public char Status { get; set; }
        public string NoPersetujuan { get; set; }
        public int BranchCode { get; set; }
        public int PinjamanKe { get; set; }
        public string No_Sppu { get; set; }
        [StringLength(1)]
        public char SistemBunga { get; set; }
        public int Tgl_JatuhTempo { get; set; }
        public int Bulan_JatuhTempo { get; set; }
        public string ModelPembayaran { get; set; }
        public int grace_periode { get; set; }

        public float Denda_Tunggakan { get; set; }
        public int JumlahDebitur { get; set; }

        public bool IsProdukUnggulan { get; set; }
        public bool IsMitraTerpilih { get; set; }
        [StringLength(900)]
        public string Jaminan { get; set; }
        public string NoRekening { get; set; }
        public string NamaBank { get; set; }
        public bool IsRealisasi { get; set; }
        public DateTime? TglRealisasi { get; set; }
        public DateTime? TglMulaiBayar { get; set; }
        [StringLength(25)]
        public string NoPenilaian { get; set; }
        [StringLength(900)]
        public string Catatan { get; set; }
        [StringLength(1000)]
        public string Kriteria { get; set; }
        [StringLength(1000)]
        public string Sinergi { get; set; }
        [StringLength(1000)]
        public string AlamatBaru { get; set; }
        public DateTime? TglAkad { get; set; }
        public int JenisProgramId { get; set; }
        [StringLength(1)]
        public char Gender { get; set; }
    }
}
