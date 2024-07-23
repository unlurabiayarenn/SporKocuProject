using SporKocu.Application.Interfaces.Repository;
using SporKocu.Domain.Entities;
using SporKocu.Infrastructure.EFCore;
using SporKocu.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Infrastructure.Repository
{
    public class RoleRepository : EFRepository<Role>, IRoleRepository
    {
        public RoleRepository(SportContext context) : base(context)
        {
        }
    }
}
