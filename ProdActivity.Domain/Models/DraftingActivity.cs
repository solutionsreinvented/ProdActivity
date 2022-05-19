using ProdActivity.Domain.Base;
using ProdActivity.Domain.Enums;
using ProdActivity.Domain.Interfaces;

namespace ProdActivity.Domain.Models
{
    public sealed class DraftingActivity : EngineeringActivity, IEngineeringActivity
    {
        public DraftingActivity(int activityId) : base(activityId)
        {
            ActivityType = EngineeringActivityType.Drafting;
        }
    }
}
