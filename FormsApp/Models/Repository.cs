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

        public static void AddProduct(Product product)
        {
            products.Add(product);
        }

        public static void EditProduct(Product product)
        {
            var productToEdit = products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if(productToEdit != null){
                productToEdit.Name = product.Name;
                productToEdit.Price = product.Price;
                productToEdit.CategoryId = product.CategoryId;
                productToEdit.Description = product.Description;
                productToEdit.ImageUrl = product.ImageUrl;
                productToEdit.IsAvailable = product.IsAvailable;
            }
        }

          public static bool DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            if(product != null){
                products.Remove(product);
                return true;
            }
            return false;
        }

        public static Product GetProductById(int id){
            return products.FirstOrDefault(product => product.ProductId == id)!;
        }

        static Repository()
        {
            categories.Add(new Category { CategoryId = 1, Name = "Laptop" });
            categories.Add(new Category { CategoryId = 2, Name = "Phone" });
            categories.Add(new Category { CategoryId = 3, Name = "Tablet" });

            products.Add(new Product { ProductId = 1, Name = "MacBook Pro", Price = 1999.99M, CategoryId = 1, ImageUrl = "1.jpg", Description = "The MacBook Pro is a line of Macintosh portable computers introduced in January 2006, by Apple Inc.", IsAvailable = true });
            products.Add(new Product { ProductId = 2, Name = "iPhone 12", Price = 999.99M, CategoryId = 2, ImageUrl = "2.jpeg", Description = "The iPhone 12 and iPhone 12 Mini are smartphones designed, developed, and marketed by Apple Inc.", IsAvailable = true });
            products.Add(new Product { ProductId = 3, Name = "iPad Pro", Price = 799.99M, CategoryId = 3, ImageUrl = "3.jpg", Description = "The iPad Pro is a line of iPad tablet computers designed, developed, and marketed by Apple Inc.", IsAvailable = true });
            products.Add(new Product { ProductId = 4, Name = "Dell XPS 13", Price = 1199.99M, CategoryId = 1, ImageUrl = "4.jpeg", Description = "The Dell XPS 13 is a line of high-end ultrabooks produced by Dell.", IsAvailable = true });
            products.Add(new Product { ProductId = 5, Name = "Samsung Galaxy S21", Price = 899.99M, CategoryId = 2, ImageUrl = "5.jpg", Description = "The Samsung Galaxy S21 is a series of Android-based smartphones designed, developed, marketed, and manufactured by Samsung Electronics.", IsAvailable = false });
            products.Add(new Product { ProductId = 6, Name = "Samsung Galaxy Tab S7", Price = 649.99M, CategoryId = 3, ImageUrl = "6.jpg", Description = "The Samsung Galaxy Tab S7 is a line of Android-based tablet computers developed and marketed by Samsung Electronics.", IsAvailable = true });
            products.Add(new Product { ProductId = 7, Name = "HP Spectre x360", Price = 1299.99M, CategoryId = 1, ImageUrl = "7.jpg", Description = "The HP Spectre x360 is a line of high-end 2-in-1 convertible laptops produced by HP.", IsAvailable = false });
            // products.Add(new Product { ProductId = 8, Name = "Google Pixel 5", Price = 699.99M, CategoryId = 2, ImageUrl = "8.jpg", Description = "The Google Pixel 5 is a smartphone part of the Google Pixel product line, serving as a successor to the Pixel 4.", IsAvailable = true });
            // products.Add(new Product { ProductId = 9, Name = "Microsoft Surface Pro 7", Price = 899.99M, CategoryId = 3, ImageUrl = "9.jpeg", Description = "The Microsoft Surface Pro 7 is a 2-in-1 detachable tablet computer developed by Microsoft.", IsAvailable = false });
        }
    }
}