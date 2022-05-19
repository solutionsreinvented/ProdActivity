using System.Collections.Generic;

using ProdActivity.Domain.Enums;

namespace ProdActivity.Domain.Interfaces
{
    public interface IEngineeringResource
    {
        List<IEngineeringActivity> Activities { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        ResourceRole ResourceRole { get; }

        string FullName { get; }

        int Id { get; set; }
    }
}