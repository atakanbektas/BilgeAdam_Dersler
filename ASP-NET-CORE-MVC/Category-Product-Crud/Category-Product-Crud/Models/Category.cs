namespace Category_Product_Crud.Models
{
    public class Category
    {
        public Category(string name)
        {
            Products = new();
            Name = name;
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
