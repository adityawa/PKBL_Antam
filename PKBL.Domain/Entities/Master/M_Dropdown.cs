using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PKBL.Domain.Entities.Master
{
    public class M_Dropdown : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [StringLength(50)]
        public string Item { get; set; }
        [StringLength(50)]
        public string Value { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
