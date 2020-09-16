using System;
using System.Collections.Generic;
using System.Text;

namespace PKBL.Domain.Entities.PK
{
    public class M_Mitra
    {
        public int Id { get; set; }
        public string RequestorAddress { get; set; }
        public string AddressDistrict { get; set; }

        public int Home_Ownership_Id { get; set; }
    }
}
