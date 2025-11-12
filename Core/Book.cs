using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core1
{
    public class Book
    {
        //先建实体类，再建config类，最后dbcontext里连接数据库加载配置
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime? PubTime { get; set; }
        public string Price { get; set; }
        public string AuthorName { get; set; }
    }
    //生成数据库，面向对象的ORM开发中，数据库并不是程序员手动生成的，而是由工具根据实体类生成的表和字段
    /*
     安装entityFrameworkCore.Tools
     1. 在 PMC 中安装 EF Core 工具包（版本与项目一致）
    Install-Package Microsoft.EntityFrameworkCore.Tools -Version 9.0.10

     PM> Add-Migration InitialCreate 会生成一个migrations文件夹，里面有一个时间戳_InitialCreate.cs文件
     PM> update-database 才会同步到数据库
    查看一下数据库，发现已经生成了表
     
     */
}
