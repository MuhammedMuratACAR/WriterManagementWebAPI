using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class WriterMap : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasKey(I => I.WriterID);
            builder.Property(I => I.WriterID).UseIdentityColumn();

            builder.Property(I => I.WriterName).HasMaxLength(100).IsRequired();
            builder.Property(I => I.WriterSurname).HasMaxLength(100).IsRequired();
            builder.Property(I => I.WriterImagePath).HasMaxLength(300);
            builder.Property(I => I.WriterAbout).HasColumnType("ntext");
            builder.Property(I => I.WriterStatus).HasDefaultValue(true);

            builder.HasMany(I => I.Headings).WithOne(I => I.Writer).HasForeignKey(I => I.WriterID);
            builder.HasMany(I => I.Contents).WithOne(I => I.Writer).HasForeignKey(I => I.WriterID);

            
        }

      
    }
}
