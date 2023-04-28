using padrao.Models;

namespace padrao.Repositories.Interfaces{
    public interface ICustoRepository{

        Task <List<CustoModel>> FindAllCusto();
        Task <CustoModel> FindOneCusto(int id);
        Task <CustoModel> AddCusto(CustoModel custoModel);

        Task <CustoModel> PatchCusto(CustoModel custoModel, int id);

        Task <bool> DeleteCusto(int id);


    }

}