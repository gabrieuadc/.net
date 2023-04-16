using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using padrao.Models;

namespace padrao.Data.Map{

    public class ImpostoMap: IEntityTypeConfiguration<ImpModels>{

        public void Configure(EntityTypeBuilder<ImpModels> builder){
            
            builder.HasKey(x=> x.Id);
            builder.Property(x=> x.rbruta).IsRequired().HasMaxLength(70);
            builder.Property(x=> x.pis).IsRequired().HasMaxLength(70);
            builder.Property(x=> x.cofins).IsRequired().HasMaxLength(70);
        }

    }


}