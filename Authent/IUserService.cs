using padrao.Models;

namespace padrao.Authent{
    public interface IUserService
    {
        Task <UsuarioModel> AuthenticateAsync(string username, string password);
    }


}