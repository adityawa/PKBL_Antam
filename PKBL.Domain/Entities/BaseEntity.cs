using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PKBL.Domain.Entities
{
    public class BaseEntity
    {
       [StringLength(50)]
       public string CreatedBy { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
