using System.ComponentModel;

namespace ProdActivity.Domain.Enums
{
    public enum ScheduleChangeReason
    {
        [Description("Change in Priority")]
        PriorityChange,
        [Description("Structural Input Pending")]
        StructuralInputPending,
        [Description("Mechanical Input Pending")]
        MechanicalInputPending
    }
}
