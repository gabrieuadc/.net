using Microsoft.EntityFrameworkCore;
using padrao.Data;
using padrao.Models;

namespace padrao.Authent{


    public class UserService : IUserService
    {

        private readonly UsuarioDBContex _usuarioDBContext;

            public UserService(UsuarioDBContex usuarioDBContex){
                this._usuarioDBContext= usuarioDBContex;

            }
        public async Task<UsuarioModel> AuthenticateAsync(string username, string password)
        {
            var user = await _usuarioDBContext.Usuarios.SingleOrDefaultAsync(x => x.Nome == username && x.Email == password);
            if(user == null){
                return null;
            }
            return user;
        }
    }



}