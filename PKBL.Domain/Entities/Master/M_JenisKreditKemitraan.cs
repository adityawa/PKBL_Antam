using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PKBL.Domain.Entities.Master
{
    public class M_JenisKreditKemitraan : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string IdJenisProgram { get; set; }
        public string Description { get; set; }
    }
}
