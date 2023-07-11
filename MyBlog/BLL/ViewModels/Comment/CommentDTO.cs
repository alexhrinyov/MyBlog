using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using MyBlog.DAL.Entities;

namespace MyBlog.BLL.ViewModels
{
    public class CommentDTO
    {
        public int Id { get; set; }

        [Display(Name = "Комментарий:")]
        [Required(ErrorMessage ="Введите текст комментария")]
        [MinLength(2, ErrorMessage ="Слишком короткий комментарий. Нужно больше двух символов.")]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserDTO User { get; set; }

    }
}
