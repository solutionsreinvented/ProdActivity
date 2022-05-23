using ProdActivity.Domain.Base;
using ProdActivity.Domain.Enums;
using ProdActivity.Domain.Interfaces;

namespace ProdActivity.Domain.Models
{
    public sealed class DesignActivity : EngineeringActivity, IEngineeringActivity
    {
        public DesignActivity(int activityId) : base(activityId)
        {
            ActivityType = EngineeringActivityType.Design;
        }

    }
}
