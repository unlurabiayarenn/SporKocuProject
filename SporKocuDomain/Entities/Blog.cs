using SporKocu.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Domain.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string HtmlContent { get; set; }
        public string CoverImagePath { get; set; }
        public int CategoryID { get; set; }

        #region Relations   

        public virtual Category Category { get; set; }

        #endregion
    }
}
