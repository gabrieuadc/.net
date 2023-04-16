using Microsoft.EntityFrameworkCore;
using padrao.Data.Map;
using padrao.Models;

namespace padrao.Data{

    public class ServiceDBContext: DbContext{


        public ServiceDBContext(DbContextOptions<ServiceDBContext> options): base(options){}

        public DbSet<ServiceModel> Services{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new ServiceMap());
            base.OnModelCreating(modelBuilder);
        }


    }



}