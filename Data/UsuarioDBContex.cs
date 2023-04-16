using Microsoft.EntityFrameworkCore;
using padrao.Models;
using padrao.Data.Map;

namespace padrao.Data{

    public class UsuarioDBContex : DbContext{

        public UsuarioDBContex(DbContextOptions<UsuarioDBContex> options)
            : base(options){}


        public DbSet<UsuarioModel> Usuarios {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }

    }

}