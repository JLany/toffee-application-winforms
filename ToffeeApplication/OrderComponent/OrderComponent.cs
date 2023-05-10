using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToffeeSystemPrototype.AccountComponent;
using ToffeeSystemPrototype.InventoryComponent;



namespace ToffeeSystemPrototype.OrderComponent
{
    internal class OrderComponent
    {
        private OrderAccountServicesContract accountComponent;
        private InventoryComponent.Inventory inventory;

        private List<Order> orders = new List<Order>();

        private static int CurrentOrderId = 1; // should load from somewhere, to keep sync with order ids in DB

        public OrderComponent(OrderAccountServicesContract accountComponent, Inventory inventory)
        {
            this.accountComponent = accountComponent;
            this.inventory = inventory;
        }

        public void PlaceOrder(Dictionary<int, int> items, List<int> voucherIds, int appliedLP
            , int accountId)
        { 
            decimal orderTotal = 0;
            foreach (var item_quantity in items)
            {
                orderTotal += inventory.GetPriceOf(item_quantity.Key) * item_quantity.Value;
                inventory.RemoveFromStock(item_quantity.Key, item_quantity.Value);
            }

        }

        public void PlaceOrder(Dictionary<int, int> itemIdQuantityPairs
            , string accountEmail)
        {
            decimal orderTotal = 0;
            foreach (var itemIdQuantityPair in itemIdQuantityPairs)
            {
                orderTotal += inventory.GetPriceOf(itemIdQuantityPair.Key) * itemIdQuantityPair.Value;
                inventory.RemoveFromStock(itemIdQuantityPair.Key, itemIdQuantityPair.Value);
            }

            var order = new Order(DateTime.Now, orderTotal
                , accountComponent.GetAddressOf(accountEmail)
                , accountEmail
                );

            order.PrintRecipt();
        }
    }
}
