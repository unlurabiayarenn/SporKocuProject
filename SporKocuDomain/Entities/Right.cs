using SporKocu.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Domain.Entities
{
    public class Right : BaseEntity
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }

        #region Relations   

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

        #endregion
    }
}
