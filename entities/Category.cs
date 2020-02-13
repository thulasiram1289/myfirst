using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firstapiii.entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Categoryname { get; set; }
        public string Categorydetails { get; set; }
    }

    public class Categorymapping : IEntityTypeConfiguration<Category>
        {
    public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.Id).UseSqlServerIdentityColumn();
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Categoryname);
            builder.Property(p => p.Categorydetails);
            builder.ToTable("T_ELITE_CAT");
        }
    }

    }

