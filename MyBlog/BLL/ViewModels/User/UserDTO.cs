using MyBlog.DAL.Enums;
using System.ComponentModel;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.BLL.ViewModels
{
    public class UserDTO
    {
        [Display(Name="Id")]
        public int Id { get; set; }
        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Укажите логин")]
        public string Login { get; set; }
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Укажите пароль")]
        public string Password { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Укажите адрес электронной почты")]
        public string Email { get; set; }
        [Display(Name = "Роль")]
        public Role Role { get; set; }
        public IEnumerable<PostDTO> Posts { get; set; }

    }
}
