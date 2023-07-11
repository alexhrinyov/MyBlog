using Microsoft.AspNetCore.Http;
using MyBlog.BLL.Response;
using MyBlog.BLL.Services.Interfaces;
using MyBlog.BLL.ViewModels;
using MyBlog.DAL;
using MyBlog.DAL.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MyBlog.BLL.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly AppDbContext context;
        public UserService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IBaseResponse<User>> Register(UserDTO model)
        {
            User user = new User()
            {
                Email = "hrinyou29@gmail.com",
                Login = "Hrinyou29",
                Password = "Kapusta777",
                Role = DAL.Enums.Role.Admin
            };
            await context.Users.AddAsync(user);
            return new BaseResponse<User>()
            {
                Description = "Пользователь добавлен"
            };
            

        }
        public Task<IBaseResponse<IEnumerable<UserDTO>>> GetUsers()
        {
            throw new NotImplementedException();
        }
        public Task<IBaseResponse<bool>> Update(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IBaseResponse<bool>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        

        

        
    }
}
