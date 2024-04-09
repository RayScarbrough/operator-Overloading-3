using System;

namespace CustomClassOperatorOverloading
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        
        public static InventoryItem operator --(InventoryItem item)
        {
            item.Quantity--;
            return item;
        }

       
        public static bool operator >(InventoryItem item1, InventoryItem item2)
        {
            return item1.Price > item2.Price;
        }

        public static bool operator <(InventoryItem item1, InventoryItem item2)
        {
            return item1.Price < item2.Price;
        }

        
        public static InventoryItem operator +(InventoryItem item1, InventoryItem item2)
        {
            return new InventoryItem
            {
                Name = item1.Name,
                Quantity = item1.Quantity + item2.Quantity,
                Price = item1.Price
            };
        }

        public override string ToString()
        {
            return $"Name: {Name}, Quantity: {Quantity}, Price: ${Price}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InventoryItem item1 = new InventoryItem { Name = "Laptop", Quantity = 10, Price = 1200.00 };
            InventoryItem item2 = new InventoryItem { Name = "Laptop", Quantity = 5, Price = 1150.00 };

            Console.WriteLine("Before operations:");
            Console.WriteLine(item1);
            Console.WriteLine(item2);

            
            item1--;
            Console.WriteLine("\nAfter decrementing quantity of item1:");
            Console.WriteLine(item1);

            
            bool isMoreExpensive = item1 > item2;
            Console.WriteLine($"\nIs item1 more expensive than item2? {isMoreExpensive}");

          
            InventoryItem combinedItem = item1 + item2;
            Console.WriteLine("\nAfter combining item1 and item2 quantities:");
            Console.WriteLine(combinedItem);

           
        }
    }
}
