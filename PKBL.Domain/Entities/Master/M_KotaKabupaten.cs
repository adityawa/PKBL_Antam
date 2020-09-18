using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PKBL.Domain.Entities.Master
{
    public class M_KotaKabupaten 
    {
      
        public string City_Id2 { get; set; }
        [StringLength(5)]
        [Key]
        public string City_Id { get; set; }
        public string City_AppCode { get; set; }
        public string City_Name { get; set; }
        public string Province_Code { get; set; }
        public string Prefix { get; set; }
    }
}
