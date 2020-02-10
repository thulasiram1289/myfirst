using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firstapiii.entity
{
    public class Category
    {
        public int Id{ get; set; }
        public string Categoryname { get; set; }
        public string Categorydetails { get; set; }
    }
    public class Categorymapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Categoryname).HasMaxLength(100);
            builder.Property(p => p.Categoryname).HasMaxLength(100);
            builder.ToTable("T_ELITE_CAT");
            
        }
    }
}
