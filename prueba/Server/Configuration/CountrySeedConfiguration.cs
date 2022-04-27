using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using prueba.Shared.Domain;

namespace prueba.Server.Configuration
{
    public class CountrySeedConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {  
                    Id = 1, 
                   Name = "Argentina",


                },
                 new Country
                 {
                     Id = 2,
                     Name = "Spain",

                 }

                );
        }
    }
}
