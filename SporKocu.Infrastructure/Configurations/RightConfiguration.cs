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
    public class RightConfiguration : IEntityTypeConfiguration<Right>
    {
        public void Configure(EntityTypeBuilder<Right> builder)
        {
            //throw new NotImplementedException();
            builder.HasData(new Right
            {
                ID = 1,
                RoleID = 1,
                CreatedBy = 1,
                CreatedDate= DateTime.Now,

            });
        }
    }
}
