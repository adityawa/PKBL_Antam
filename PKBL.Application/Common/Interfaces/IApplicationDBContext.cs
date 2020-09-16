using Microsoft.EntityFrameworkCore;
using PKBL.Domain.Entities.PK;
using System;
using System.Collections.Generic;
using System.Text;

namespace PKBL.Application.Common.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<M_Mitra> M_Mitras { get; set; }
    }
}
