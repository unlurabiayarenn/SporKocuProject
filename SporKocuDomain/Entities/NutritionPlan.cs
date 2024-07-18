using SporKocu.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Domain.Entities
{
    public class NutritionPlan :BaseEntity
    {
        public int UserID { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #region Relations   

        public ICollection<NutritionPlanDetail> NutritionPlans { get; set; }

        #endregion

    }
}
