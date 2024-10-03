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
        [DisplayName("Tên công ty")]
        public string Name { get; set; }

        [DisplayName("Ngành nghề")]
        public string Industry { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }

        public string? Logo { get; set; }

        [DisplayName("Website")]
        public string Website { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

        [DisplayName("Ngày tạo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Create { get; set; }

        [DisplayName("Ngày cập nhật")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Update { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
    }
}
