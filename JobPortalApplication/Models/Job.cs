using JobPortalApplication.Models.Enum;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalApplication.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Requirements { get; set; }
        [Required]
        public string Benefits { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public DateTime? ExpiredDate { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int EmployerId { get; set; }
        [ForeignKey("EmployerId")]
        [ValidateNever]
        public Employer Employer { get; set; }
        public JobLevel JobLevel { get; set; }
        public JobType JobType { get; set; }
        public JobStatus JobStatus { get; set; }
        public bool IsHot { get; set; }
        public bool IsFeature { get; set; }
        public bool IsDeleted { get; set; }

    }
}
