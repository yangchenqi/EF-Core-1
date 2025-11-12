using EF_core1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core
{
    class BirdConfig : IEntityTypeConfiguration<Bird>
    {
        public void Configure(EntityTypeBuilder<Bird> builder)
        {
            builder.ToTable("T_Birds");
            builder.HasKey(b => b.Number);//设置主键
            builder.Property(b => b.Name).IsRequired().HasMaxLength(100).HasDefaultValue("lilili");//设置非空，最大长度，默认值
            builder.Property(b => b.Id).IsRequired();
        }
    }
}
