using ProdActivity.Domain.Base;
using ProdActivity.Domain.Enums;
using ProdActivity.Domain.Interfaces;

namespace ProdActivity.Domain.Models
{
    public sealed class LeadEngineer : EngineeringResource, IEngineeringResource
    {
        public LeadEngineer(int employeeId) : base(employeeId)
        {
            ResourceRole = ResourceRole.LeadEngineer;
        }
    }
}
