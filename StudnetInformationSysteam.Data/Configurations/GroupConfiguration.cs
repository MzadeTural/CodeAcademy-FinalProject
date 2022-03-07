using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentIformationSysteam.Core.Models;

namespace StudnetInformationSysteam.Data.Configurations
{

    internal class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);




        }
    }
}
