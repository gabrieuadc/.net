using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using padrao.Models;

namespace padrao.Data.Map{

    public class UsuarioMap: IEntityTypeConfiguration<UsuarioModel>{

        public void Configure(EntityTypeBuilder<UsuarioModel> builder){

            builder.HasKey(x=> x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(70);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(70);
        }

    }

}