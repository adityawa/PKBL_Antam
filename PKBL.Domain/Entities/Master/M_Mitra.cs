using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PKBL.Domain.Entities.Master
{
    public class M_Mitra : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        
        public string RequestorAddress { get; set; }
        public string AddressDistrict { get; set; }
        public int HomeOwnershipId { get; set; }
        [StringLength(64)]
        public string RequestorPhone1 { get; set; }
        [StringLength(64)]
        public string RequestorPhone2 { get; set; }
        [StringLength(64)]
        public string RequestorMail { get; set; }

        public int MaritalStatusId { get; set; }

        public int EducationLevelId { get; set; }
        public int CompanyDataId { get; set; }

        public int Family_Relative_ID { get; set; }
        public int Other_Relative_ID { get; set; }
        public int Car_Mortage_ID { get; set; }

        public int Motorcycle_Mortage_ID { get; set; }
        public int Other_Mortage_ID { get; set; }
        public string MortageRemarks { get; set; }

        public int Administrative_Id { get; set; }
        public int Production_Activity_Id1 { get; set; }
        public int Production_Activity_Id2 { get; set; }
        public int Production_Activity_Id3 { get; set; }
        public int Production_Activity_Id4 { get; set; }

        public bool IsProductHandMade { get; set; }
        public bool IsMachineMade { get; set; }
        public string Owned_Tool1 { get; set; }
        public int Owned_Tool1_count { get; set; }

        public string Owned_Tool2 { get; set; }
        public int Owned_Tool2_count { get; set; }

        public string Owned_Tool3 { get; set; }
        public int Owned_Tool3_count { get; set; }

        public string Owned_Tool4 { get; set; }
        public int Owned_Tool4_count { get; set; }

        public string Service_Provided { get; set; }
        public string Marketing { get; set; }

        public bool IsLocalMarket { get; set; }

        public bool IsExport { get; set; }

        public int Checklist_Id { get; set; }

        public string UploadedFile { get; set; }
        public int InventoryUpdateId { get; set; }
        public string MGRNoProposal { get; set; }
        public DateTime? TglBermasalah { get; set; }

    }
}
