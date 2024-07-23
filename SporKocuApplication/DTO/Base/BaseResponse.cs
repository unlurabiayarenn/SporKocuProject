﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Application.DTO.Base
{
    public class BaseResponse<T>
    {
        public T Entity { get; set; }
        public List<T> EntityList { get; set; }
    }
}
