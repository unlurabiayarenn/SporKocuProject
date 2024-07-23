using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SporKocu.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Infrastructure.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasIndex(x=>x.Title).IsUnique();
            builder.HasData(new Role
            {
                ID = 1,
                Title = "Admin",
                Description = "Admin",
                CreatedBy =1,
                CreatedDate = DateTime.Now,

            }); ;//default datalar için
            //throw new NotImplementedException();
        }
    }
}
