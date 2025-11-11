using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core1
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthPlace { get; set; }
        //新加一列，然后运行add-migration Add_BirthPlace命令，会根据实体类生成对应的表和字段
        //然后再运行update-database命令，同步到数据库
    }
}
