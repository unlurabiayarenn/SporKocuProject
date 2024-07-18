using SporKocu.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Domain.Entities
{
    public class Answer :BaseEntity
    {
        public int QuestionID { get; set; }
        public string Description { get; set; }
        public int Step { get; set; }
        public int UserID { get; set; }

        #region Relations

        public virtual Question Question { get; set; }
        public virtual User User { get; set; }

        #endregion
    }
}
