using EFCoreDemo.repo;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("EF");

var container = new ServiceCollection();
var provider = container.AddDbContext<ProductDatabase>().BuildServiceProvider();

using (var db = provider.GetRequiredService<ProductDatabase>())
{
    //db.Products.Add(new Product { ProductName = "lenovo", Price = 2000 });
    //int result = db.SaveChanges();
    //Console.WriteLine(result > 0 ? "added" : "failed");

    //var found = db.Products.Where(p => p.ProductId == 3).FirstOrDefault();
    //if(found != null)
    //{
    //    found.Price = 3000;
    //    int res = db.SaveChanges();
    //    Console.WriteLine(res > 0 ? "updated" : "failed");
    //}

    var found = db.Products.Where(p => p.ProductId == 3).FirstOrDefault();
    if (found != null)
    {
        db.Products.Remove(found);
        int res = db.SaveChanges();
        Console.WriteLine(res > 0 ? "deleted" : "failed");
    }
    var records = db.Products;
    records.ToList().ForEach(x => Console.WriteLine(x.ProductName));
}
