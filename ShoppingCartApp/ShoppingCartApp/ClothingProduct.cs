using System;

namespace ShoppingCartApp
{
    public class ClothingProduct : Product
    {
        private string size;
        private string color;

        public string Size { get { return size; } }
        public string Color { get { return color; } }

        public ClothingProduct(string name, double price, ProductCategory category, string size, string color)
            : base(name, price, category)
        {
            this.size = size;
            this.color = color;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Size: {size}, Color: {color}");
        }
    }


    namespace ShoppingCartApp
    {
        namespace ShoppingCartApp
        {
            public class ShoppingCart
            {
                private Product[] products;
                private int itemCount;

                public Product[] Products { get { return products; } }
                public int ItemCount { get { return itemCount; } }

                public ShoppingCart(int capacity)
                {
                    products = new Product[capacity];
                }

                public void AddProduct(Product product)
                {
                    products[itemCount++] = product;
                }

                public void RemoveProduct(Product product)
                {
                    for (int i = 0; i < itemCount; i++)
                    {
                        if (products[i] == product)
                        {
                            products[i] = null; // Nullify the reference to the removed product
                            itemCount--;
                            break;
                        }
                    }
                }
            }
        }

    }
    }
    