using Microsoft.EntityFrameworkCore;
using PKBL.Domain.Entities.Master;
using PKBL.Domain.Entities.PK;
using System;
using System.Collections.Generic;
using System.Text;

namespace PKBL.Application.Common.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<M_Mitra> M_Mitras { get; set; }
        DbSet<M_CabProp> M_CabProps { get; set; }
        DbSet<M_Company> M_Companies { get; set; }
        DbSet<M_Dropdown> M_Dropdowns { get; set; }
        DbSet<M_JenisKreditKemitraan> M_JenisKreditKemitraans { get; set; }
        DbSet<M_KantorCabang> M_KantorCabangs { get; set; }
        DbSet<M_KotaKabupaten> M_KotaKabupatens { get; set; }
        DbSet<M_Province> M_Provinces { get; set; }
        DbSet<M_RefDataUsahaMitra> M_RefDataUsahaMitras { get; set; }
        DbSet<M_SektorKemitraan> M_SektorKemitraans { get; set; }
        DbSet<M_Supplier> M_Suppliers { get; set; }
    }
}
