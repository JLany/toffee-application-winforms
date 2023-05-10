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
        public DateTime CreatedDate { get; set; }
        public decimal OrderTotal { get; set; } = 0;
        public string OrderAddress { get; set; }
        private OrderStatus OrderStatus { get; set; }
        private string AccountEmail { get; set; }

        public Order(DateTime createdDate, decimal orderTotal
            , string orderAddress, string accountEmail)
        {
            CreatedDate = createdDate;
            OrderTotal = orderTotal;
            OrderAddress = orderAddress;
            OrderStatus = OrderStatus.Active;
            AccountEmail = accountEmail;
        }

        public void Deliver()
        {
            OrderStatus = OrderStatus.Delivered;
        }

        public void PrintRecipt()
        {
            MessageBox.Show(
                $"For Account: {AccountEmail}\nOrder Total: {OrderTotal}\nAddress: {OrderAddress}\nCreated: {CreatedDate}"
                , "Your Order has been confirmed."
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information
                );            
        }

        public void PrintSummary()
        {
            //Console.WriteLine($"Order {Id}");
            Console.WriteLine($"Order Total: ${OrderTotal}");
            Console.WriteLine(OrderStatus.ToString());
        }

        public void Cancel()
        {
            OrderStatus = OrderStatus.Canceled;
        }
    }
}
