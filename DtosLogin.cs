using System.ComponentModel.DataAnnotations;

namespace FirstProject.Dtos
{
    public class DtosLogin
    {
        [Required(ErrorMessage = "اسم المستخدم مطلوب.")]
        public string username { get; set; }
        [Required(ErrorMessage = "كلمة المرور مطلوبة.")]
        public string password { get; set; }
    }
}
