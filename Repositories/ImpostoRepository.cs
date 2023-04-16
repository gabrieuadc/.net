using Microsoft.EntityFrameworkCore;
using padrao.Data;
using padrao.Models;
using padrao.Repositories.Interfaces;

namespace padrao.Repositories{

    public class ImpostoRepository: IImpostosRepository{

        private readonly ImpostosDBContex _dbContex;

        public ImpostoRepository(ImpostosDBContex impostosDBContex){
            _dbContex= impostosDBContex;

        }

        public async Task<ImpModels> AddImp(ImpModels impModels)
        {
            await _dbContex.Imp.AddAsync(impModels);
            await _dbContex.SaveChangesAsync();
            return impModels;
        }


        public async Task<List<ImpModels>> FindAllImp()
        {
            return await _dbContex.Imp.ToListAsync();
        }

        public async Task<ImpModels> FindOneImp(int id)
        {
            return await _dbContex.Imp.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ImpModels> PatchImp(ImpModels impModels, int id)
        {
            ImpModels impbyid = await FindOneImp(id);

            if(impbyid == null){
                throw new Exception("Usuário não encontrado");
            }

            impbyid.Id= impModels.Id;
            _dbContex.Imp.Update(impbyid);
            await _dbContex.SaveChangesAsync();
            return impbyid;
        }

        public async Task<bool> DeleteImp(int id)
        {
            ImpModels impbyid = await FindOneImp(id);

            if(impbyid == null){
                throw new Exception("Usuário não encontrado");
            }

            _dbContex.Imp.Remove(impbyid);
            await _dbContex.SaveChangesAsync();
            return true;
        }
    }


}
