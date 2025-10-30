using EF_core1;
using System.Linq;

using (MyDbContext ctx = new MyDbContext()) { 
    var book = new Book()
    {
        Title = "C#高级编程",
        PubTime = DateTime.Now,
        Price = "88.8"
    };
    //插入数据
    ctx.Books.Add(book);//把book对象添加到逻辑上的Books表中

    //查询数据  大部分linq语句都是可以被EF core转换成sql语句的
    var books = ctx.Books.Where(b => b.Price == "88.8").ToList();
    foreach (var b in books)
    {
        Console.WriteLine($"{b.Id} {b.Title} {b.PubTime} {b.Price}");
    }

    //修改数据  删除数据
    var cb = ctx.Books.Where(b=>b.Title == "C#高级编程").FirstOrDefault();
    cb.PubTime = DateTime.Now.AddDays(-10);
    await ctx.SaveChangesAsync();

    var d = ctx.Persons.Single(x=>x.Id == 1);//查询主键为1的Person对象
    ctx.Persons.Remove(d);//删除这个对象

    ctx.SaveChanges();//update-database  才算是真正的插入到数据库
    //目前没有高效的批量插入方法，可以暂时使用Zack.EFCore.Batch Extensions这个第三方库 
}

