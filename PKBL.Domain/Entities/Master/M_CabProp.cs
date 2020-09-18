using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PKBL.Domain.Entities.Master
{
    public class M_CabProp :BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [StringLength(30)]
        public string Cabang { get; set; }
        [ForeignKey("M_Province")]
        public int Propinsi { get; set; }

        public M_Province Province { get; set; }
    }
}
