using padrao.Models;

namespace padrao.Repositories.Interfaces{
    public interface IImpostosRepository{

        Task <List<ImpModels>> FindAllImp();
        Task <ImpModels> FindOneImp(int id);
        Task <ImpModels> AddImp(ImpModels impModels);

        Task <ImpModels> PatchImp(ImpModels impModels, int id);

        Task <bool> DeleteImp(int id);


    }

}