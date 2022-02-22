using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(I => I.CategoryID);
            builder.Property(I => I.CategoryID).UseIdentityColumn();

            builder.Property(I => I.CategoryName).HasMaxLength(50).IsRequired();
            builder.Property(I => I.CategoryStatus).HasDefaultValue(true);

            builder.HasMany(I => I.Headings).WithOne(I => I.Category).HasForeignKey(I => I.CategoryID);
        }
    }
}
