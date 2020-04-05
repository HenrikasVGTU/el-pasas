namespace el_pasas.Interfaces
{
    public interface ITokenService
    {
        /// <summary>
        /// Validates user session
        /// </summary>
        /// <param name="userId">Personal number</param>
        /// <param name="token">Token value</param>
        /// <returns>True, if user session is valid</returns>
        bool IsSessionValid(string userId, string token);
    }
}
