using System.ComponentModel;

namespace JobPortalApplication.Models.Enum
{
    public enum JobLevel
    {
        [Description("Intern")]
        Intern,
        [Description("Fresher")]
        Fresher,
        [Description("Junior")]
        Junior,
        [Description("Middle")]
        Middle,
        [Description("Senior")]
        Senior,
    }
}
