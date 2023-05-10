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

        private List<Order> orderes;
        private List<Payment> payments;


        private static int CurrentOrderId = 1; // should load from somewhere, to keep sync with order ids in DB

        public OrderComponent(OrderAccountServicesContract accountComponent, Inventory inventory)
        {
            this.accountComponent = accountComponent;
            this.inventory = inventory;
            orderes = new List<Order>();
            payments = new List<Payment>();
        }

        public void PlaceOrder(Dictionary<int, int> items, List<int> voucherIds, int appliedLP
            , int accountId)
        {
            Order newOrder = new Order(CurrentOrderId++, items.Keys.ToList());
            /*
                        decimal voucherDiscount;
                        if (accountComponent.ValidateVouchers(accountId, voucherIds))
                        {
                            voucherDiscount = accountComponent.RedeemVouchers(accountId, voucherIds);
                        }
            */
            decimal orderTotal = 0;
            foreach (var item_quantity in items)
            {
                orderTotal += inventory.GetPriceOf(item_quantity.Key) * item_quantity.Value;
            }

            accountComponent.CreditLP(accountId, (int)orderTotal);

            //inventory.RemoveFromStock(items);
        }

        // public void PlaceOrder(Dictionary<Item, int> itemQuantityPairs, )
    }
}
