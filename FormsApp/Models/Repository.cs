namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> products = [];
        private static readonly List<Category> categories = [];

        public static List<Product> Products
        {
            get
            {
                return products;
            }
        }

        public static List<Category> Categories
        {
            get
            {
                return categories;
            }
        }

        static Repository()
        {
            categories.Add(new Category { CategoryId = 1, Name = "Laptop" });
            categories.Add(new Category { CategoryId = 2, Name = "Phone" });
            categories.Add(new Category { CategoryId = 3, Name = "Tablet" });
        }
    }
}