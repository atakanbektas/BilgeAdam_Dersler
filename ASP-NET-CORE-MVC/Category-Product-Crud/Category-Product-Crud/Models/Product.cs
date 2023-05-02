namespace Category_Product_Crud.Models
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public Product()
        {

        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
