using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JobPortalApplication.Models.ViewModels
{
    public class JobVM
    {
        public Job Job { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> EmployerList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> JobLevelList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> JobTypeList { get; set; }
    }
}
