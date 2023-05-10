using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToffeeSystemPrototype.InventoryComponent
{
    internal class Item
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double AvailableQuantity { get; set; }

        /// <summary>
        /// Takes values between 0 and 100 inclusive
        /// </summary>
        public double DiscountPercentage { get; set; } = 0.0;

        public ItemUnitType UnitType { get; set; }

        private ItemStatus status = ItemStatus.OnSale;
        public ItemStatus Status
        {
            get
            {
                return AvailableQuantity > 0 ? ItemStatus.OnSale : ItemStatus.OutOfStock;
            }
            set { status = value; }
        }

        public decimal SalePrice 
        {
            get => Price - (Price * (decimal)(DiscountPercentage / 100));
        }

        
        public Item(int id, string name, string description, decimal price, double quantity
            , double discountPercentage, ItemUnitType unitType) 
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            AvailableQuantity = quantity;
            DiscountPercentage = discountPercentage;
            UnitType = unitType;
        }

        public override string ToString() => $"{Id} | {Name} | ${Price}";
    }
}
