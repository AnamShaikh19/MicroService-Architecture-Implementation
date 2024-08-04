using Mango.web.Models;

namespace Mango.web.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync (RequestDto requestDto);
    }
}
