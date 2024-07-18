using SporKocu.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Domain.Entities
{
    public class NutritionPlanDetail : BaseEntity
    {
        public int NutritionPlanID { get; set; }
        public int FoodID { get; set; }
        public string Meal { get; set; }

        #region Relations   

        public virtual NutritionPlan NutritionPlan  { get; set; }

        #endregion
    }
}
