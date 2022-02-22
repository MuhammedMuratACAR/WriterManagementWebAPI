using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class ContentMap : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.HasKey(I => I.ContentID);
            builder.Property(I => I.ContentID).UseIdentityColumn();

            builder.Property(I => I.ContentValue).HasColumnType("ntext");
            builder.Property(I => I.ContentStatus).HasDefaultValue(true);

        }
    }
}
