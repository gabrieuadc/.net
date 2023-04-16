using Microsoft.EntityFrameworkCore;
using padrao.Repositories.Interfaces;
using padrao.Models;
using padrao.Data;

namespace padrao.Repositories{
    public class UsuarioRepository: IUsuariosRepository{

        private readonly UsuarioDBContex _dbContext;
        public UsuarioRepository(UsuarioDBContex usuarioDBContext){
            _dbContext= usuarioDBContext;
        }


        public async Task<List<UsuarioModel>> FindAllUser(){
            return await _dbContext.Usuarios.ToListAsync();
        }
        public async Task<UsuarioModel> FindById(int id){
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<UsuarioModel> Add(UsuarioModel usuario){
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }
        public async Task<UsuarioModel> Patch(UsuarioModel usuario, int id){
            UsuarioModel usuarioporId= await FindById(id);

            if(usuarioporId == null){
                throw new Exception("Usuário para o id: não foi encontrado.");
            }
            usuarioporId.Nome= usuario.Nome;
            _dbContext.Usuarios.Update(usuarioporId);
            await _dbContext.SaveChangesAsync();
            return usuarioporId;


        }
        public async Task<bool> Delete(int id){
            UsuarioModel usuarioporId = await FindById(id);

            if(usuarioporId == null){
                throw new Exception("Usuario nao encontrado");
            }

            _dbContext.Usuarios.Remove(usuarioporId);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }

}

            // return await _dbContext.Usuarios.FirstOrDefaultAsync(x =>x.Id == id);