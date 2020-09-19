
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PKBL.Application.Common.Interfaces;
using PKBL.Domain.Entities;
using PKBL.Domain.Entities.Master;
using PKBL.Domain.Entities.PK;
using PKBL.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            UpdateTimestamp();

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public override int SaveChanges()
        {

            UpdateTimestamp();

            return base.SaveChanges();
        }

        private void UpdateTimestamp()
        {
            var entries = ChangeTracker
                            .Entries()
                            .Where(e => e.Entity is BaseEntity && (
                            e.State == EntityState.Added
                            || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).ModifiedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).IsDeleted = false;
                    ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }
        }
    }
}
