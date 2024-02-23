using Test_Aiko.Models.JwtConfiguration;

namespace Test_Aiko.Interfaces
{
    public interface IAuthenticationBusinessLogics
    {
        string GenerateToken(string username, JwtConfiguration jwtConfiguration);
    }
}
