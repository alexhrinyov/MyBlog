using System.ComponentModel.DataAnnotations;

namespace MyBlog.BLL.ViewModels
{
    public class TagDTO
    {
        public int Id { get; set; }
        [Display(Name = "Название тега")]
        public string Title { get; set; }   
    }
}
