using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core1
{
    internal class BookConfig:IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //Fluent API 配置实体类映射到数据库表的信息
            builder.ToTable("T_Books");

            //// 配置 Title：nvarchar(50)、非空、索引（可选，提升查询效率）
            //builder.Property(b => b.Title)
            //      .HasColumnType("nvarchar(50)") // 变长字符串，最大50字符
            //      .IsRequired();// 不允许为 NULL

            //// 配置 Price：decimal(18,2)（18位总长度，2位小数，符合金额场景）
            //builder.Property(b => b.Price)
            //      .HasColumnType("decimal(18,2)")
            //      .IsRequired(); // 不允许为 NULL

            //// 配置 PubTime：datetime2(7)（精确到毫秒，默认已支持，显式配置更清晰）
            //builder.Property(b => b.Price)
            //      .HasColumnType("datetime2(7)");

            //builder.Property(b => b.AuthorName)
            //      .HasColumnType("nvarchar(12)") // 变长字符串，最大12字符
            //      .IsRequired(false); // 允许为 NULL
        }
    }
}
