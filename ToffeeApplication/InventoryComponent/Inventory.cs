using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToffeeSystemPrototype.InventoryComponent
{
    internal class Inventory
    {
        private Dictionary<int, Item> items = new Dictionary<int, Item>();

        public Inventory() 
        {
            LoadItems();
        }
        

        // set of services for order component

        public decimal GetPriceOf(int itemId)
        {
            return items[itemId].Price;
        }

        public void RemoveFromStock(List<int> itemIds)
        {
            foreach (int itemId in itemIds)
            {
                items.Remove(itemId);
            }
        }

        // set of services for Inventory controller

        public void UpdateItem(int itemId,  Item item)
        {

        }

        public Dictionary<int, Item> GetItemCatalog()
        {
            return items;
        }












        private void LoadItems()
        {
            Item i1 = new Item(441, "Galaxy", "Very Delicious", 10m, 16, 0.0, ItemUnitType.Sealed);
            Item i2 = new Item(514, "Snickers", "Meh Meh", 5m, 6, 0.0, ItemUnitType.Sealed);
            Item i3 = new Item(411, "El Abd", "Crunchy Ma'mool", 19m, 5, 50.0, ItemUnitType.Loose);
            Item i4 = new Item(113, "Milky Way", "Dripping Choco", 70m, 51, 0.0, ItemUnitType.Sealed);
            Item i5 = new Item(111, "London Daily", "Not Recommended", 34m, 21, 0.0, ItemUnitType.Sealed);
            Item i6 = new Item(861, "Bounty", "Bonus Choco", 3m, 75, 0.0, ItemUnitType.Sealed);
            Item i7 = new Item(789, "Candy", "Breaks Your Teeth", 1m, 13, 0.0, ItemUnitType.Sealed);
            Item i8 = new Item(658, "Gum", "Hides Your Breath", 52m, 14, 0.0, ItemUnitType.Sealed);
            Item i9 = new Item(384, "Sobia", "For Sobia Lovers Only", 2m, 5, 15.0, ItemUnitType.Loose);
            Item i10 = new Item(278, "Date", "Take It on Your Date", 7m, 4, 0.0, ItemUnitType.Loose);
            Item i11 = new Item(163, "Twix", "Chocolate Coverd Biscuites", 9m, 2, 0.0, ItemUnitType.Sealed);

            items.Add(i1.Id, i1);
            items.Add(i2.Id, i2);
            items.Add(i3.Id, i3);
            items.Add(i4.Id, i4);
            items.Add(i5.Id, i5);
            items.Add(i6.Id, i6);
            items.Add(i7.Id, i7);
            items.Add(i8.Id, i8);
            items.Add(i9.Id, i9);
            items.Add(i10.Id, i10);
            items.Add(i11.Id, i11);
        }
    }
}
