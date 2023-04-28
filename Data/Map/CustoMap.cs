using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using padrao.Models;

namespace padrao.Data.Map{

    public class CustoMap: IEntityTypeConfiguration<CustoModel>{

        public void Configure(EntityTypeBuilder<CustoModel> builder){
            
            builder.HasKey(x=> x.id);
            builder.Property(x=> x.cc).IsRequired().HasMaxLength(70);
            builder.Property(x=> x.mod).IsRequired();
            builder.Property(x=> x.md).IsRequired();
            builder.Property(x=> x.cif).IsRequired();
            builder.Property(x=> x.cpp).IsRequired();
            builder.Property(x=> x.exercicio).IsRequired().HasMaxLength(70);
        }

    }


}