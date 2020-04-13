using ComplaintsApp.API.Dtos;
using ComplaintsApp.API.Models;

namespace ComplaintsApp.API.Services
{
    public interface IAuthService
    {
         LoggedInUserDto Login(UserForLoginDto userForLoginDto);
    }
}