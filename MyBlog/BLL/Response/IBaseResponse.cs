using Microsoft.AspNetCore.Http;

namespace MyBlog.BLL.Response
{
    public interface IBaseResponse<T>
    {
        string Description { get; }
        //StatusCode StatusCode { get; }
        T Data { get; }
    }
}
