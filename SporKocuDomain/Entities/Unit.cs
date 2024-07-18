﻿using SporKocu.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Domain.Entities
{
    public class Unit :BaseEntity
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    }
}
