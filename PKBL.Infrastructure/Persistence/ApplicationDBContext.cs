
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PKBL.Application.Common.Interfaces;
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
        
    }
}
