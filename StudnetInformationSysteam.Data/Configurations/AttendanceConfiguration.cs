using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudnetInformationSysteam.Data.Configurations
{
    public class AttendanceConfiguration :IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.Property(x => x.LessonDate).IsRequired().HasColumnType("DateTime"); 
            builder.Property(x => x.IsPresent).IsRequired(); 
           


        }
    }
}
