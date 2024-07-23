using Microsoft.EntityFrameworkCore;
using SporKocu.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            //throw new NotImplementedException();
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasData(new User
            {
                ID = 1,
                Email= "admin@admin.com",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                Password= "123456",
                Adress= "123456",
                Fullname ="Rabia ünlü",
                Phonenumber= "123456",
                PremiumPackage= 1,
                ProfilePicUrl=""
            });
        }
    }
}
