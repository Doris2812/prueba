using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using prueba.Shared.Domain;

namespace prueba.Server.Configuration
{
    public class PersonSeedConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person
                {
                    Id = 1,
                    Name =  "Doris",
                    CountryId = 1,

                },


                 new Person
                 {
                     Id = 2,
                     Name = "Maria",
                     CountryId = 2,

                 }


                );
        }
    }
}
