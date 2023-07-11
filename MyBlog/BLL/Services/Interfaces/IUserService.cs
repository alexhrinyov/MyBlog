using MyBlog.BLL.Response;
using MyBlog.DAL.Entities;
using MyBlog.BLL.ViewModels;

namespace MyBlog.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<IBaseResponse<User>> Register(UserDTO model);
        Task<IBaseResponse<IEnumerable<UserDTO>>> GetUsers();
        Task<IBaseResponse<bool>> Update(int id);
        Task<IBaseResponse<bool>> Delete(int id);
        
    }
}
