using MyBlog.DAL.Enums;
using MyBlog.BLL.ViewModels;
using System.Data;

namespace MyBlog.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public IEnumerable<PostDTO> Posts { get; set; }

    }
}
