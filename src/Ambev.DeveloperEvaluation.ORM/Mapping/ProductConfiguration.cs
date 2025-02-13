using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Common.Security;
using System.Reflection.Emit;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{   
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.UnitPrice).IsRequired();
            builder.Property(p => p.Discount);
            builder.Property(p => p.TotalAmount);
            builder.Property(p => p.Cancelled).IsRequired();            
        }
    }
}
