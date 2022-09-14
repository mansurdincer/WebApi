namespace WebApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(100)]
        public string Description { get; set; }
        
        [Precision(18, 2)]        
        public decimal Cost { get; set; }
        
        public int Stock { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
