using System.Threading.Tasks;
using ComplaintsApp.API.Models;

namespace ComplaintsApp.API.Data
{
    public interface IAuthRepository
    {
        User Login(string username, string password);
    }
}