using padrao.Models;

namespace padrao.Repositories.Interfaces{


    public interface IUsuariosRepository{
        Task<List<UsuarioModel>> FindAllUser();
        Task<UsuarioModel> FindById(int id);
        Task<UsuarioModel> Add(UsuarioModel usuario);
        Task<UsuarioModel> Patch(UsuarioModel usuario, int id);
        Task<bool> Delete(int id);
    }

}