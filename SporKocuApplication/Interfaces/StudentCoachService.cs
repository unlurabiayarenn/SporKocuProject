using SporKocu.Application.DTO.Request;
using SporKocu.Application.DTO.Response;
using SporKocu.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Application.Interfaces
{
    public interface StudentCoachService :IGenericService<StudentCoachResponse,StudentCoachRequest>
    {
    }
}
