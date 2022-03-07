using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudnetInformationSysteam.Data.Configurations
{
    internal class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);




        }
    }
}
