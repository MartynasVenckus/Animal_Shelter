using Šitie.Dtos;

namespace Šitie.Services.Interfaces
{
    public interface IAuthService
    {
        User AuthenticateUser(LoginDto login);
        string GenerateToken(User user);

    }
}
