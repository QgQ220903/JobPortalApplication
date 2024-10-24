using System.ComponentModel;

namespace JobPortalApplication.Models.Enum
{
    public enum JobStatus
    {
        [Description("Pending")]
        Pending,
        [Description("Approved")]
        Approved,
        [Description("Rejected")]
        Rejected
    }
}
