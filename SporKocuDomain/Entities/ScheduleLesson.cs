using SporKocu.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Domain.Entities
{
    public class ScheduleLesson : BaseEntity
    {
        public int UserID { get; set; }
        public DateTime StartDate { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
        public string? Note { get; set; }
    }
}
