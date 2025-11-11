using EF_core1;
using System.Linq;

//ctx相当于逻辑上的数据库
using (MyDbContext ctx = new MyDbContext()) {
    //var book = new Book()
    //{
    //    Title = "C#高级编程",
    //    PubTime = DateTime.Now,
    //    Price = "88.8",
    //    AuthorName="x"
    //};

    //var book2 = new Book()
    //{
    //    Title = "我们俩",
    //    PubTime = DateTime.Now,
    //    Price = "98",
    //    AuthorName = "y"
    //};

    //var book3 = new Book()
    //{
    //    Title = "C",
    //    PubTime = DateTime.Now,
    //    Price = "70",
    //    AuthorName = "c"
    //};
    ////插入数据
    //ctx.Books.Add(book);//把book对象添加到逻辑上的Books表中
    //ctx.Books.Add(book2);
    //ctx.Books.Add(book3);
    //ctx.SaveChanges();//update-database  才算是真正的插入到数据库
    ////运行项目，然后去数据库查看数据已经插入功

    //查询数据  大部分linq语句都是可以被EF core转换成sql语句的
    //var books = ctx.Books.Where(b => b.Price == "88.8").ToList();
    //foreach (var b in books)
    //{
    //    Console.WriteLine($"{b.Id} {b.Title} {b.PubTime} {b.Price}");
    //}

    ////修改数据  删除数据
    //var cb = ctx.Books.Where(b => b.Title == "C#高级编程").FirstOrDefault();
    //cb.PubTime = DateTime.Now.AddDays(-10);
    //await ctx.SaveChangesAsync();

    var d = ctx.Books.Single(x => x.Id == 5);//查询主键为5的Book对象
    ctx.Books.Remove(d);//删除这个对象

    ctx.SaveChanges();//update-database  才算是真正的插入到数据库
    ////目前没有高效的批量插入方法，可以暂时使用Zack.EFCore.Batch Extensions这个第三方库 
}

