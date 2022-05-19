using ProdActivity.Domain.Base;
using ProdActivity.Domain.Enums;
using ProdActivity.Domain.Interfaces;

namespace ProdActivity.Domain.Models
{
    public sealed class Engineer : EngineeringResource, IEngineeringResource
    {
        public Engineer(int employeeId) : base(employeeId)
        {
            ResourceRole = ResourceRole.Engineer;
        }
    }
}
