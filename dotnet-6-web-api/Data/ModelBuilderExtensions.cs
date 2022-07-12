using dotnet_6_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_6_web_api.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales" },
                new Category { Id = 2, Name = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings" },
                new Category { Id = 3, Name = "Confections", Description = "Desserts, candies, and sweet breads" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Chai", Price = 18, IsAvailable = true },
                new Product { Id = 2, CategoryId = 1, Name = "Chang", Price = 19, IsAvailable = true },
                new Product { Id = 24, CategoryId = 1, Name = "Guaraná Fantástica", Price = 4.5M, IsAvailable = true },
                new Product { Id = 34, CategoryId = 1, Name = "Sasquatch Ale", Price = 14, IsAvailable = true },
                new Product { Id = 35, CategoryId = 1, Name = "Steeleye Stout", Price = 18, IsAvailable = true },
                new Product { Id = 38, CategoryId = 1, Name = "Côte de Blaye", Price = 263.5M, IsAvailable = true },
                new Product { Id = 39, CategoryId = 1, Name = "Chartreuse verte", Price = 18, IsAvailable = true },
                new Product { Id = 43, CategoryId = 1, Name = "Ipoh Coffee", Price = 46, IsAvailable = true },
                new Product { Id = 70, CategoryId = 1, Name = "Outback Lager", Price = 15, IsAvailable = true },
                new Product { Id = 67, CategoryId = 1, Name = "Laughing Lumberjack Lager", Price = 14, IsAvailable = true },
                new Product { Id = 75, CategoryId = 1, Name = "Rhönbräu Klosterbier", Price = 7.75M, IsAvailable = false },
                new Product { Id = 76, CategoryId = 1, Name = "Lakkalikööri", Price = 18, IsAvailable = true },
                new Product { Id = 13, CategoryId = 2, Name = "Chef Anton's Cajun Seasoning", Price = 125, IsAvailable = true },
                new Product { Id = 14, CategoryId = 2, Name = "Chef Anton's Gumbo Mix", Price = 55, IsAvailable = true },
                new Product { Id = 15, CategoryId = 2, Name = "Grandma's Boysenberry Spread", Price = 22, IsAvailable = true },
                new Product { Id = 16, CategoryId = 2, Name = "Northwoods Cranberry Sauce", Price = 95, IsAvailable = true },
                new Product { Id = 17, CategoryId = 2, Name = "Genen Shouyu", Price = 17, IsAvailable = true },
                new Product { Id = 18, CategoryId = 3, Name = "Teatime Chocolate Biscuits", Price = 2.8M, IsAvailable = true },
                new Product { Id = 19, CategoryId = 3, Name = "Sir Rodney's Marmalade", Price = 2.8M, IsAvailable = true },
                new Product { Id = 20, CategoryId = 3, Name = "NuNuCa Nuß-Nougat-Creme", Price = 2.8M, IsAvailable = true },
                new Product { Id = 21, CategoryId = 3, Name = "Gumbär Gummibärchen", Price = 2.8M, IsAvailable = true },
                new Product { Id = 22, CategoryId = 3, Name = "Schoggi Schokolade", Price = 2.8M, IsAvailable = true },
                new Product { Id = 23, CategoryId = 3, Name = "Zaanse koeken", Price = 2.8M, IsAvailable = true },
                new Product { Id = 80, CategoryId = 3, Name = "Chocolade", Price = 24.99M, IsAvailable = true },
                new Product { Id = 25, CategoryId = 3, Name = "Valkoinen suklaa", Price = 9.99M, IsAvailable = true },
                new Product { Id = 26, CategoryId = 3, Name = "Maxilaku", Price = 12.49M, IsAvailable = true },
                new Product { Id = 27, CategoryId = 3, Name = "Tarte au sucre", Price = 13.99M, IsAvailable = true },
                new Product { Id = 28, CategoryId = 3, Name = "Scottish Longbreads", Price = 12.49M, IsAvailable = true }); 
        }
    }
    

 









}
