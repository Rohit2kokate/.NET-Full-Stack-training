using System;
using System.Collections.Generic;

namespace RestaurantBilling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hotel Details
            string hotelName = "Grand Restaurant";
            double gstRate = 0.18; // 18% GST

            // Menu Items
            Dictionary<int, MenuItem> menu = new Dictionary<int, MenuItem>
            {
                { 1, new MenuItem { Name = "Pizza", Price = 8.99 } },
                { 2, new MenuItem { Name = "Burger", Price = 5.49 } },
                { 3, new MenuItem { Name = "Pasta", Price = 7.99 } },
                { 4, new MenuItem { Name = "Salad", Price = 4.99 } }
            };

            // Order List
            List<MenuItem> order = new List<MenuItem>();

            while (true)
            {
                Console.WriteLine("Restaurant Menu:");
                foreach (var item in menu)
                {
                    Console.WriteLine($"{item.Key}. {item.Value.Name} - ${item.Value.Price:F2}");
                }

                Console.WriteLine("Enter the item number to add to your order, or '0' to finish and generate the bill:");
                int itemNumber = int.Parse(Console.ReadLine());

                if (itemNumber == 0)
                    break;

                if (menu.ContainsKey(itemNumber))
                {
                    order.Add(menu[itemNumber]);
                    Console.WriteLine($"{menu[itemNumber].Name} has been added to your order.");
                }
                else
                {
                    Console.WriteLine("Invalid item number. Please try again.");
                }
            }

            GenerateBill(order, hotelName, gstRate);
        }

        static void GenerateBill(List<MenuItem> order, string hotelName, double gstRate)
        {
            double subtotal = 0;
            Console.WriteLine("\n--------------------");
            Console.WriteLine(hotelName);
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine("--------------------");
            Console.WriteLine("Your Order:");
            foreach (var item in order)
            {
                Console.WriteLine($"{item.Name} - ${item.Price:F2}");
                subtotal += item.Price;
            }

            double gst = subtotal * gstRate;
            double total = subtotal + gst;

            Console.WriteLine("--------------------");
            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"GST (18%): ${gst:F2}");
            Console.WriteLine($"Total: ${total:F2}");
            Console.WriteLine("--------------------");
            Console.WriteLine("Thank you for dining with us!");
        }
    }

    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}