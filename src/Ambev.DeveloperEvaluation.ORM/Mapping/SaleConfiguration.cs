using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{

    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(p => p.DateSale).IsRequired();
            builder.Property(p => p.Customer).IsRequired().HasMaxLength(200);
            builder.Property(p => p.TotaSaleAmount).IsRequired();
            builder.Property(p => p.Branch).HasMaxLength(200);
            builder.Property(p => p.Cancelled).IsRequired();

            builder.HasMany(s => s.Products).WithOne().HasForeignKey(s => s.SaleId);
        }
    }
}
