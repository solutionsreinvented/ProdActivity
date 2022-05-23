using System;
using System.Collections.Generic;

using ProdActivity.Domain.Enums;
using ProdActivity.Domain.Models;

namespace ProdActivity.Domain.Interfaces
{
    public interface IEngineeringActivity
    {

        int Id { get; set; }

        ProjectType ProjectType { get; set; }

        string Description { get; set; }

        Project Project { get; set; }

        EngineeringActivityType ActivityType { get; set; }

        CompletionStatus CurrentStatus { get; set; }

        HashSet<IEngineeringResource> AllocatedResources { get; set; }

        HashSet<Change> Changes { get; set; }

        DateTime InitiatedOn { get; set; }

        DateTime ScheduledCompletion { get; set; }

        public void SetCompletionInHours(int totalHoursRequired);

        public void SetCompletionInDays(int totalDaysRequired);
    }
}