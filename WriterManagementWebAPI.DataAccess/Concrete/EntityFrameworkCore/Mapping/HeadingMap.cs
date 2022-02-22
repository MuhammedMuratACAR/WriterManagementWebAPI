using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class HeadingMap : IEntityTypeConfiguration<Heading>
    {
        public void Configure(EntityTypeBuilder<Heading> builder)
        {
            builder.HasKey(I => I.HeadingID);
            builder.Property(I => I.HeadingID).UseIdentityColumn();

            builder.Property(I => I.HeadingName).HasMaxLength(100);
            builder.Property(I => I.HeadingStatus).HasDefaultValue(true);

            builder.HasMany(I => I.Contents).WithOne(I => I.Heading).HasForeignKey(I => I.HeadingID);
        }
    }
}
