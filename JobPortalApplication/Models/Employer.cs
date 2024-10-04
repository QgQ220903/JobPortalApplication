using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace JobPortalApplication.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Fullname { get; set; }

        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        public  Company Company { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Create { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Update { get; set; }
        public bool Status { get; set; }



    }
}
