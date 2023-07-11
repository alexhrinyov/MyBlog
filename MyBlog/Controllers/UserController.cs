using Microsoft.AspNetCore.Mvc;
using MyBlog.BLL.Services.Interfaces;

namespace MyBlog.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        /*
* В контроллере пользователей реализовать логику регистрации, редактирования, 
* удаления пользователя, а также логику получения всех пользователей и логику 
* получения только одного пользователя по его идентификатору
* */

        public IActionResult Index()
        {
            userService.Register(null);
            return View();
        }
    }
}
