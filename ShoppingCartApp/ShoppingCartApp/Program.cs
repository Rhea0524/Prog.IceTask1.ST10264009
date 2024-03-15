using ShoppingCartApp; // Include ShoppingCartApp namespace only once
using ShoppingCartApp.ShoppingCartApp.ShoppingCartApp;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create products based on user input
            Console.WriteLine("Enter details for the clothing product:");
            Console.Write("Name: ");
            string clothingName = Console.ReadLine();
            Console.Write("Price: ");
            double clothingPrice = double.Parse(Console.ReadLine());
            Console.Write("Size: ");
            string clothingSize = Console.ReadLine();
            Console.Write("Color: ");
            string clothingColor = Console.ReadLine();
            Product clothingProduct = new ClothingProduct(clothingName, clothingPrice, ProductCategory.Clothing, clothingSize, clothingColor);

            Console.WriteLine("\nEnter details for the electronics product:");
            Console.Write("Name: ");
            string electronicsName = Console.ReadLine();
            Console.Write("Price: ");
            double electronicsPrice = double.Parse(Console.ReadLine());
            Console.Write("Brand: ");
            string electronicsBrand = Console.ReadLine();
            Console.Write("Model: ");
            string electronicsModel = Console.ReadLine();
            Product electronicsProduct = new ElectronicsProduct(electronicsName, electronicsPrice, ProductCategory.Electronics, electronicsBrand, electronicsModel);

            // Create a shopping cart
            ShoppingCart cart = new ShoppingCart(10); // Capacity of 10 products

            // Add products to the shopping cart
            cart.AddProduct(clothingProduct);
            cart.AddProduct(electronicsProduct);

            // Display the contents of the shopping cart
            Console.WriteLine("\nShopping Cart Contents:");
            foreach (Product product in cart.Products)
            {
                if (product != null)
                {
                    product.GetInfo();
                }
            }
            Console.WriteLine($"Total Items in Cart: {cart.ItemCount}");

            // Remove a product from the shopping cart
            cart.RemoveProduct(electronicsProduct);

            // Display the updated contents of the shopping cart
            Console.WriteLine("\nUpdated Shopping Cart Contents:");
            foreach (Product product in cart.Products)
            {
                if (product != null)
                {
                    product.GetInfo();
                }
            }
            Console.WriteLine($"Total Items in Cart: {cart.ItemCount}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
