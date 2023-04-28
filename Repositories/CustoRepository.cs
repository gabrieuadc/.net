using Microsoft.EntityFrameworkCore;
using padrao.Data;
using padrao.Models;
using padrao.Repositories.Interfaces;

namespace padrao.Repositories{

    public class CustoRepository: ICustoRepository{

        private readonly CustoDBContext _dbContex;

        public CustoRepository(CustoDBContext custoDBContex){
            _dbContex= custoDBContex;

        }

        public async Task<CustoModel> AddCusto(CustoModel custoModel)
        {
            await _dbContex.Custo.AddAsync(custoModel);
            await _dbContex.SaveChangesAsync();
            return custoModel;

        }

        public async Task<bool> DeleteCusto(int id)
        {
            CustoModel custobyid = await FindOneCusto(id);

            if(custobyid == null){
                throw new Exception("not found for id");
            }

            _dbContex.Custo.Remove(custobyid);
            await _dbContex.SaveChangesAsync();
            return true;
        }

        public async Task<List<CustoModel>> FindAllCusto()
        {
            return await _dbContex.Custo.ToListAsync();
        }

        public async Task<CustoModel> FindOneCusto(int id)
        {
            return await _dbContex.Custo.FirstOrDefaultAsync(x=> x.id==id);
        }

        public async Task<CustoModel> PatchCusto(CustoModel custoModel, int id)
        {
            CustoModel custobyid = await FindOneCusto(id);

            if(custobyid == null){
                throw new Exception("not found for id");
            }

            custobyid.cc= custoModel.cc;
            _dbContex.Custo.Update(custobyid);
            await _dbContex.SaveChangesAsync();
            return custobyid;
        }
    }
}
