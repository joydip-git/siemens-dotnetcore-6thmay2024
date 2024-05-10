using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.repo
{
    [Table("products")]
    public class Product
    {
        [Key]
        [Column(name:"id")]
        public int ProductId { get; set; }

        [Column(name:"name",TypeName ="varchar(50)")]       
        public string ProductName { get; set; } = "";

        public decimal Price { get; set; }
    }
}
