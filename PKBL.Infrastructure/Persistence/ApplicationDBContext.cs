
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PKBL.Application.Common.Interfaces;
using PKBL.Domain.Entities.Master;
using PKBL.Domain.Entities.PK;
using PKBL.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PKBL.Infrastructure.Persistence
{
    public class ApplicationDbContext: IdentityDbContext<AppUser>, IApplicationDBContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<M_Mitra> M_Mitras { get; set; }
        public DbSet<M_CabProp> M_CabProps { get; set; }
        public DbSet<M_Company> M_Companies { get ; set ; }
        public DbSet<M_Dropdown> M_Dropdowns { get; set; }
        public DbSet<M_JenisKreditKemitraan> M_JenisKreditKemitraans { get; set; }
        public DbSet<M_KantorCabang> M_KantorCabangs { get; set; }
        public DbSet<M_KotaKabupaten> M_KotaKabupatens { get; set; }
        public DbSet<M_Province> M_Provinces { get; set; }
        public DbSet<M_RefDataUsahaMitra> M_RefDataUsahaMitras { get; set; }
        public DbSet<M_SektorKemitraan> M_SektorKemitraans { get; set; }
        public DbSet<M_Supplier> M_Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
        
    }
}
