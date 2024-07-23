﻿using SporKocu.Application.DTO.Request;
using SporKocu.Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Application.Interfaces
{
    public interface IUnitService :IGenericService<UnitResponse,UnitRequest>
    {
    }
}
