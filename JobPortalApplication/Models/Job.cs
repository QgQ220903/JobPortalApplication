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
        public string Benefits { get; set; }
        public double Salary { get; set; }
        public DateTime Create { get; set; }
        public DateTime? Update { get; set; }
        [Required]
        public DateTime? Expired { get; set; }    
        
        public int EmployerId { get; set; }
        [ForeignKey("EmployerId")]
        [ValidateNever]
        public Employer Employer { get; set; }
        public int JobLevelId { get; set; }
        [ForeignKey("JobLevelId")]
        [ValidateNever]
        public JobLevel JobLevel { get; set; }
        public int JobTypeId { get; set; }
        [ForeignKey("JobTypeId")]
        [ValidateNever]
        public JobType JobType { get; set; }
        public string Location { get; set; }
        public bool Status { get; set; }
    }
}
