using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobPortalApplication.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }


        public string Industry { get; set; }


        public string Description { get; set; }

        public string? Logo { get; set; }


        public string Website { get; set; }


        public string Email { get; set; }


        public string Phone { get; set; }


      /*  [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]*/
        public DateTime Create { get; set; }


/*        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]*/
        public DateTime? Update { get; set; }


        public bool Status { get; set; }
    }
}
