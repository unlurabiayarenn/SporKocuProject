using SporKocu.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Domain.Entities
{
    public class StudentCoach : BaseEntity
    {
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }

        #region Relations   

        public virtual Category Category { get; set; }

        #endregion
    }
}
