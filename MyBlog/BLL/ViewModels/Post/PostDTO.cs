using System.ComponentModel.DataAnnotations;
namespace MyBlog.BLL.ViewModels

{
    public class PostDTO
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Заголовок")]
        [Required(ErrorMessage ="Укажите заголовок")]
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Текст поста")]
        [Required(ErrorMessage = "Текст не должен быть пустым")]
        [MinLength(50,ErrorMessage ="Текст не может быть  меньше 50 символов")]
        public string Text { get; set; }
        [Display(Name = "Нравится")]
        public int Likes { get; set; }
        [Display(Name = "Не нравится")]
        public int DisLikes { get; set; }
        public IEnumerable<CommentDTO> Comments { get; set; }
        public IEnumerable<TagDTO> Tags { get; set; }

    }
}
