using System.ComponentModel;

namespace ProdActivity.Domain.Enums
{
    public enum CompletionStatus
    {
        [Description("Completed")]
        Completed,
        [Description("On Track")]
        OnTrack,
        [Description("Rescheduled")]
        Rescheduled,
        [Description("Temporary Hold")]
        TemporaryHold,
        [Description("Permanent Hold")]
        PermanentHold
    }
}
