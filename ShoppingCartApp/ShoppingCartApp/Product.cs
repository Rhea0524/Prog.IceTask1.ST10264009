using System;

namespace ShoppingCartApp
{
    public enum ProductCategory
    {
        Clothing,
        Electronics,
        Home,
        Beauty,
        Groceries
    }

    public class Product
    {
        private string name;
        private double price;
        private ProductCategory category;

        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public ProductCategory Category { get { return category; } }

        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {name}, Price: {price}, Category: {category}");
        }
    }
}
