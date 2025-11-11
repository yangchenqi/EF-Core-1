using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core1
{
    [Table("T_Cats")]
    //把配置以特性的形式写在实体类上
    public class Cats
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        //运行add-migration Add_Cats命令时，会根据实体类生成对应的表和字段
        //然后再运行update-database命令，同步到数据库
    }
}
