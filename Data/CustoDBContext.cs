using Microsoft.EntityFrameworkCore;
using padrao.Data.Map;
using padrao.Models;

namespace padrao.Data{

    public class CustoDBContext: DbContext{

        public CustoDBContext(DbContextOptions<CustoDBContext> options): base (options){}


    public DbSet<CustoModel> Custo{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new CustoMap());
            base.OnModelCreating(modelBuilder);
        }


        }

}