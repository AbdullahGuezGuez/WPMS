using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);

         Task<User> Login(string username, string password);

         Task<bool> UserExist(string username);

    }
}