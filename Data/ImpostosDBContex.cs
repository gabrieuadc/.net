using Microsoft.EntityFrameworkCore;
using padrao.Data.Map;
using padrao.Models;

namespace padrao.Data{

    public class ImpostosDBContex: DbContext{


        public ImpostosDBContex(DbContextOptions<ImpostosDBContex> options)
            : base (options){}


    public DbSet<ImpModels> Imp{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new ImpostoMap());
            base.OnModelCreating(modelBuilder);
        }


        }

}