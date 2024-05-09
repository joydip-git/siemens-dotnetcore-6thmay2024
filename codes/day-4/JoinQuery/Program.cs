JoinQueryFunc();
static void JoinQueryFunc()
{
    List<Category> categories =
        [
            new(){Id=1, Name="Laptop"},
            new(){Id=2, Name="Mobile"},
            new(){Id=3, Name="Books"},
        ];
    List<Product> products =
        [
            new(){ Id=1, Name="Dell", Price=1000, Category=categories[0] },
            new(){ Id=2, Name="One+", Price=2000, Category=categories[1] },
            new(){ Id=3, Name="HP", Price=3000, Category=categories[0] },
            new(){ Id=4, Name="IPhone", Price=4000, Category=categories[1] }
        ];
    /*
     * productname price categoryname
     */
    //var joinQuery = from p in products
    //                join c in categories on p.Category?.Id equals c.Id
    //                select new { ProductName = p.Name, p.Price, CategoryName = c.Name };
    //joinQuery.ToList().ForEach(record => Console.WriteLine($"{record.ProductName}, {record.Price}, {record.CategoryName}"));

    //left outer (group) join
    var groupJoinQyery =
        from c in categories
        join p in products on c.Id equals p.Category?.Id into cpGroup
        orderby c.Name
        select new
        {
            CategoryName = c.Name,
            Products =
            from prod in cpGroup.DefaultIfEmpty(
                new Product { Name = "NA" })
            orderby prod.Name
            select new { prod.Name }
        };



    groupJoinQyery
        .ToList()
        .ForEach(
            item =>
            {
                Console.WriteLine(item.CategoryName);
                Console.WriteLine("--------------");
                item
                .Products
                .ToList()
                .ForEach(p => Console.WriteLine(p.Name));
                Console.WriteLine("\n");
            }
        );



    /**
     * Laptop
     * ------------------
     * 
     * Mobile
     * ---------------------
     * 
     */


}
class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}
class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public int CategoryId { get; set; }

    //navigation or association property
    public Category? Category { get; set; }
}
