using System.ComponentModel.DataAnnotations;

namespace JobPortalApplication.Models
{
    public class JobLevel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
