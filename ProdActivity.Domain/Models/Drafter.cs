using ProdActivity.Domain.Base;
using ProdActivity.Domain.Enums;
using ProdActivity.Domain.Interfaces;

namespace ProdActivity.Domain.Models
{
    public sealed class Drafter : EngineeringResource, IEngineeringResource
    {
        public Drafter(int employeeId) : base(employeeId)
        {
            ResourceRole = ResourceRole.Drafter;
        }


    }
}
