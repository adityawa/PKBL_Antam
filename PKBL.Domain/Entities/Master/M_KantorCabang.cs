using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PKBL.Domain.Entities.Master
{
    public class M_KantorCabang : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string HeadName { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }

        public string Province_Code { get; set; }
    }
}
