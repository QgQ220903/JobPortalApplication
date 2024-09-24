using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobPortalApplication.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập tên kỹ năng")]
        [DisplayName("Tên Kỹ Năng")]
        public string Name { get; set; }
        [DisplayName("Trạng Thái")]
        public bool Status { get; set; }
    }
}
