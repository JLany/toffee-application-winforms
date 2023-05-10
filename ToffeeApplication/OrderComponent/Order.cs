using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToffeeSystemPrototype.InventoryComponent;

namespace ToffeeSystemPrototype.OrderComponent
{
    internal class Order
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; } // this should be list<items ids>
        public OrderStatus Status { get; set; }
        private decimal orderTotal;

        public Order(int id, List<int> itemIds)
        {
            Id = id;
            Items = new List<Item>();
            Status = OrderStatus.Active;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
            orderTotal += item.Price;
        }

        public void PrintRecipt()
        {
            Console.WriteLine($"Order {Id}");
            foreach (Item item in Items)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine($"Order Total: ${orderTotal}");
        }

        public void PrintSummary()
        {
            Console.WriteLine($"Order {Id}");
            Console.WriteLine($"Order Total: ${orderTotal}");
            Console.WriteLine(Status.ToString());
        }

        public void Cancel()
        {
            Status = OrderStatus.Canceled;
        }

        public void Deliver()
        {
            Status = OrderStatus.Delivered;
        }
    }
}
