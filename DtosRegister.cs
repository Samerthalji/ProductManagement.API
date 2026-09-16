using System.ComponentModel.DataAnnotations;

namespace FirstProject.Dtos
{
    public class DtosRegister
    {
        [Required(ErrorMessage = "اسم المستخدم مطلوب.")]
        public string ussername { get; set; } = string.Empty;

        [Required(ErrorMessage = "البريد الإلكتروني مطلوب.")]
        [EmailAddress(ErrorMessage = "صيغة البريد الإلكتروني غير صحيحة.")]
        public string email { get; set; } = string.Empty;

        [Required(ErrorMessage = "كلمة المرور مطلوبة.")]
        [MinLength(6, ErrorMessage = "كلمة المرور يجب أن لا تقل عن 6 خانات.")]
        public string password { get; set; } = string.Empty;

        [Required(ErrorMessage = "الدور مطلوب.")]
        public string Role { get; set; } = "User";
    }
}
