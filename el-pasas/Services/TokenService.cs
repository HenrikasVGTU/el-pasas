using el_pasas.Interfaces;

namespace el_pasas.Services
{
    public class TokenService : ITokenService
    {
        public bool IsSessionValid(string userId, string token)
        {
            return true;
        }
    }
}
